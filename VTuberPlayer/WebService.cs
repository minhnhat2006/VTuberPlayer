using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VTuberPlayer
{
    public class WebService : IWebService
    {
        private const string host = "localhost";
        private static string listenerPrefix;
        private static HttpListener listener;
        private static bool shouldStopListener = false;
        private static Task mainListenerTask;
        private MainWindow mainWindow;

        public WebService(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        /// <summary>
        /// Start listener on specific port.
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public void StartListener(int port)
        {
            try
            {
                listenerPrefix = $"http://{host}:{port}/";
                listener = new HttpListener { Prefixes = { listenerPrefix } };

                if (mainListenerTask != null && !mainListenerTask.IsCompleted)
                {
                    //Already started
                    return;
                }

                mainListenerTask = startListenerTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot start web listener on {listenerPrefix}\n{ex.Message}");
            }
        }


        /// <summary>
        /// The main loop to handle requests into the HttpListener
        /// </summary>
        /// <returns></returns>
        private async Task startListenerTask()
        {
            listener.Start();
            while (!shouldStopListener)
            {
                try
                {
                    var context = await listener.GetContextAsync();
                    lock (listener)
                    {
                        if (!shouldStopListener) processRequest(context);
                    }
                }
                catch (HttpListenerException ex)
                {
                    MessageBox.Show($"Cannot start web listener on {listenerPrefix}\n{ex.Message}");
                    return;
                }
            }
        }

        /// <summary>
        /// Handle an incoming request.
        /// </summary>
        /// <param name="context">The context of the incoming request</param>
        private void processRequest(HttpListenerContext context)
        {
            using (var response = context.Response)
            {
                try
                {
                    var handled = false;
                    switch (context.Request.Url.AbsolutePath)
                    {
                        case "/play/animation":
                            switch (context.Request.HttpMethod)
                            {
                                case "GET":
                                case "POST":
                                    new Task(() => mainWindow.PlayAnimation()).Start();
                                    buildSuccessResponse(response, "ok");
                                    handled = true;
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show($"Cannot process request url: {context.Request.Url.AbsolutePath}, method: {context.Request.HttpMethod}");
                            break;
                    }
                    if (!handled)
                    {
                        response.StatusCode = 404;
                    }
                }
                catch (Exception ex)
                {
                    //Return the exception details the client
                    response.StatusCode = 500;
                    response.ContentType = "text/html";
                    var buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(ex));
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);

                    MessageBox.Show($"Cannot process request url: {context.Request.Url.AbsolutePath}, method: {context.Request.HttpMethod}\n{ex.Message}");
                }
            }
        }

        private static void buildSuccessResponse(HttpListenerResponse response, string responseMessage)
        {
            response.ContentType = "text/plain";
            //Write it to the response stream
            var buffer = Encoding.UTF8.GetBytes(responseMessage);
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.StatusCode = 200;
        }

        /// <summary>
        /// Stop listen on specific port.
        /// </summary>
        /// <param name="port"></param>
        public void StopListener(int port)
        {
            shouldStopListener = true;
            lock (listener)
            {
                //Use a lock so we don't kill a request that's currently being processed
                listener.Stop();
            }

            try
            {
                mainListenerTask.Wait();
                MessageBox.Show($"Stopped web listener on {listenerPrefix}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot stop web listener on {listenerPrefix}\n{ex.Message}");
            }
        }
    }
}
