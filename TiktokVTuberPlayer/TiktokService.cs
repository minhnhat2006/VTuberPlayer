using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Events.MessageData.Messages;
using TikTokLiveSharp.Events.MessageData.Objects;

namespace TiktokVTuberPlayer
{
    public class TiktokService : ITiktokService
    {
        private MainWindow mainWindow;
        private TikTokLiveClient client;
        private CancellationTokenSource cancellationTokenSource;

        public TiktokService(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        private void Client_OnConnected(TikTokLiveClient sender, bool e)
        {
            SetConsoleColor(ConsoleColor.White);

            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"Connected to Room! [Connected:{e}]";
                mainWindow.HasStartedTiktokListener = true;
            });
        }

        private void Client_OnDisconnected(TikTokLiveClient sender, bool e)
        {
            SetConsoleColor(ConsoleColor.White);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"Disconnected from Room! [Connected:{e}]";
            });
        }

        private void Client_OnViewerData(TikTokLiveClient sender, RoomViewerData e)
        {
            SetConsoleColor(ConsoleColor.Cyan);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"Viewer count is: {e.ViewerCount}";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnLiveEnded(TikTokLiveClient sender, EventArgs e)
        {
            SetConsoleColor(ConsoleColor.White);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = "Host ended Stream!";
            });
        }

        private void Client_OnJoin(TikTokLiveClient sender, Join e)
        {
            SetConsoleColor(ConsoleColor.Green);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.User.UniqueId} joined!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnComment(TikTokLiveClient sender, Comment e)
        {
            SetConsoleColor(ConsoleColor.Yellow);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.User.UniqueId}: {e.Text}";
            });
            SetConsoleColor(ConsoleColor.White);

            //this.mainWindow.Dispatcher.Invoke(() =>
            //{
            //    mainWindow.NotifyMessage = e.Text;
            //    mainWindow.PlayAnimation(1);
            //});
        }

        private void Client_OnFollow(TikTokLiveClient sender, Follow e)
        {
            SetConsoleColor(ConsoleColor.DarkRed);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.NewFollower?.UniqueId} followed!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnShare(TikTokLiveClient sender, Share e)
        {
            SetConsoleColor(ConsoleColor.Blue);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.User?.UniqueId} shared!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnSubscribe(TikTokLiveClient sender, Subscribe e)
        {
            SetConsoleColor(ConsoleColor.DarkCyan);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.NewSubscriber.UniqueId} subscribed!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnLike(TikTokLiveClient sender, Like e)
        {
            SetConsoleColor(ConsoleColor.Red);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.Sender.UniqueId} liked!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnGiftMessage(TikTokLiveClient sender, GiftMessage e)
        {
            //SetConsoleColor(ConsoleColor.Magenta);
            //Console.WriteLine($"{e.Sender.UniqueId} sent {e.Amount}x {e.Gift.Name}!");

            //this.mainWindow.Dispatcher.Invoke(() =>
            //{
            //    mainWindow.NotifyMessage = $"{e.Sender.UniqueId} sent {e.Amount}x {e.Gift.Name}!";

            //    switch (e.Gift.Name)
            //    {
            //        case "Rose":
            //            mainWindow.PlayAnimation(1);
            //            break;
            //        default:
            //            mainWindow.PlayAnimation(2);
            //            break;
            //    }
            //});

            //SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnGift(TikTokLiveClient sender, TikTokGift e)
        {
            //SetConsoleColor(ConsoleColor.Magenta);
            //Console.WriteLine($"{e.Sender.UniqueId} sent {e.Amount}x {e.Gift.Name}!");

            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.Sender.UniqueId} sent {e.Amount}x {e.Gift.Name}!";

                switch (e.Gift.Name)
                {
                    case "Rose":
                        mainWindow.PlayAnimation(1);
                        break;
                    default:
                        mainWindow.PlayAnimation(2);
                        break;
                }
            });

            //SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnEmote(TikTokLiveClient sender, Emote e)
        {
            SetConsoleColor(ConsoleColor.DarkGreen);
            this.mainWindow.Dispatcher.Invoke(() =>
            {
                mainWindow.NotifyMessage = $"{e.User.UniqueId} sent {e.EmoteId}!";
            });
            SetConsoleColor(ConsoleColor.White);
        }

        private void SetConsoleColor(ConsoleColor color)
        {
            if (Console.ForegroundColor != color)
                Console.ForegroundColor = color;
        }

        /// <summary>
        /// Start listener.
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public void StartListener()
        {
            try
            {
                string username = mainWindow.TiktokUsername;
                new Task(() => StartListenerTask(username)).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot start tiktok listener\n{ex.Message}");
            }
        }

        /// <summary>
        /// The main loop to handle requests into the HttpListener
        /// </summary>
        /// <returns></returns>
        private void StartListenerTask(string username)
        {
            try
            {
                client = new TikTokLiveClient(username);
                client.OnConnected += Client_OnConnected;
                client.OnDisconnected += Client_OnDisconnected;
                client.OnViewerData += Client_OnViewerData;
                client.OnLiveEnded += Client_OnLiveEnded;
                client.OnJoin += Client_OnJoin;
                client.OnComment += Client_OnComment;
                client.OnFollow += Client_OnFollow;
                client.OnShare += Client_OnShare;
                client.OnSubscribe += Client_OnSubscribe;
                client.OnLike += Client_OnLike;
                client.OnGiftMessage += Client_OnGiftMessage;
                client.OnGift += Client_OnGift;
                client.OnEmote += Client_OnEmote;
                cancellationTokenSource = new CancellationTokenSource();
                CancellationToken cancellationToken = cancellationTokenSource.Token;
                client.Run(cancellationToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot start tiktok listener\n{ex.Message}");
            }
        }

        /// <summary>
        /// Stop listener.
        /// </summary>
        /// <param name="port"></param>
        public async Task StopListenerAsync()
        {
            try
            {
                if (client != null)
                {
                    await client.Stop();

                    if (cancellationTokenSource != null)
                    {
                        cancellationTokenSource.Cancel();
                    }

                    this.mainWindow.Dispatcher.Invoke(() =>
                    {
                        mainWindow.HasStartedTiktokListener = false;
                    });
                }
            }
            catch (Exception ex)
            {
                if (ex is OperationCanceledException) return;
                MessageBox.Show($"Cannot stop tiktok listener\n{ex.Message}");
            }
        }
    }
}
