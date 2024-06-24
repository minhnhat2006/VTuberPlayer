using System;
using System.Windows;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Events.MessageData.Messages;
using VTuberPlayer.Properties;

namespace VTuberPlayer
{
    public class TiktokService : ITiktokService
    {
        private MainWindow mainWindow;

        public TiktokService(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;

            string username = Settings.Default.TiktokUsername;
            var client = new TikTokLiveClient(username);
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
            client.OnEmote += Client_OnEmote;
            client.Run(new System.Threading.CancellationToken());
        }

        private void Client_OnConnected(TikTokLiveClient sender, bool e)
        {
            SetConsoleColor(ConsoleColor.White);
            Console.WriteLine($"Connected to Room! [Connected:{e}]");
        }

        private void Client_OnDisconnected(TikTokLiveClient sender, bool e)
        {
            SetConsoleColor(ConsoleColor.White);
            Console.WriteLine($"Disconnected from Room! [Connected:{e}]");
        }

        private void Client_OnViewerData(TikTokLiveClient sender, RoomViewerData e)
        {
            SetConsoleColor(ConsoleColor.Cyan);
            Console.WriteLine($"Viewer count is: {e.ViewerCount}");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnLiveEnded(TikTokLiveClient sender, EventArgs e)
        {
            SetConsoleColor(ConsoleColor.White);
            Console.WriteLine("Host ended Stream!");
        }

        private void Client_OnJoin(TikTokLiveClient sender, Join e)
        {
            SetConsoleColor(ConsoleColor.Green);
            Console.WriteLine($"{e.User.UniqueId} joined!");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnComment(TikTokLiveClient sender, Comment e)
        {
            SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine($"{e.User.UniqueId}: {e.Text}");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnFollow(TikTokLiveClient sender, Follow e)
        {
            SetConsoleColor(ConsoleColor.DarkRed);
            Console.WriteLine($"{e.NewFollower?.UniqueId} followed!");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnShare(TikTokLiveClient sender, Share e)
        {
            SetConsoleColor(ConsoleColor.Blue);
            Console.WriteLine($"{e.User?.UniqueId} shared!");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnSubscribe(TikTokLiveClient sender, Subscribe e)
        {
            SetConsoleColor(ConsoleColor.DarkCyan);
            Console.WriteLine($"{e.NewSubscriber.UniqueId} subscribed!");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnLike(TikTokLiveClient sender, Like e)
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine($"{e.Sender.UniqueId} liked!");
            SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnGiftMessage(TikTokLiveClient sender, GiftMessage e)
        {
            //SetConsoleColor(ConsoleColor.Magenta);
            //Console.WriteLine($"{e.Sender.UniqueId} sent {e.Amount}x {e.Gift.Name}!");

            switch (e.Gift.Name)
            {
                case "Rose":
                    mainWindow.PlayAnimation(1);
                    break;
                default:
                    mainWindow.PlayAnimation(2);
                    break;
            }

            //SetConsoleColor(ConsoleColor.White);
        }

        private void Client_OnEmote(TikTokLiveClient sender, Emote e)
        {
            SetConsoleColor(ConsoleColor.DarkGreen);
            Console.WriteLine($"{e.User.UniqueId} sent {e.EmoteId}!");
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
        public void StartListener(int port)
        {
            try
            {

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
        public void StopListener(int port)
        {
            try
            {
                MessageBox.Show($"Stopped tiktok listener");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot stop tiktok listener\n{ex.Message}");
            }
        }
    }
}
