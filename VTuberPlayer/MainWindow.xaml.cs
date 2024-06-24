using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace VTuberPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string DefaultVideo = "Data/main.mp4";
        private Queue<string> videosQueue = new Queue<string>();
        private string prevVideo = DefaultVideo;
        private bool fullscreen = false;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            mePlayer.MediaEnded += mePlayer_MediaEnded;
            mePlayer.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            // Initialize tiktok listener
            ITiktokService webService = new TiktokService(this);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mePlayer.Source != null)
            {
                if (mePlayer.NaturalDuration.HasTimeSpan)
                {
                    lblStatus.Content = String.Format("{0} / {1}", mePlayer.Position.ToString(@"mm\:ss"), mePlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                }
            }
            else
            {
                lblStatus.Content = "No file selected...";
            }
        }

        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            toogleFullscreen(fullscreen);
            fullscreen = !fullscreen;
        }

        private void toogleFullscreen(bool isFullscreen)
        {
            if (!isFullscreen)
            {
                this.gridRoot.Children.Remove(mePlayer);
                this.Content = mePlayer;
                this.WindowStyle = WindowStyle.None;
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.Content = this.gridRoot;
                this.gridRoot.Children.Add(mePlayer);
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.WindowState = WindowState.Normal;
            }
        }

        public void EscShortcut(Object sender, ExecutedRoutedEventArgs e)
        {
            if (fullscreen)
            {
                toogleFullscreen(true);
                fullscreen = false;
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Source = new Uri(DefaultVideo, UriKind.Relative);
            mePlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Stop();
        }

        private void btnPlay_Anim1(object sender, RoutedEventArgs e)
        {
            PlayAnimation();
        }

        public void PlayAnimation(int animationIndex = 1)
        {
            if (animationIndex < 1 || animationIndex > 2)
            {
                animationIndex = 1;
            }
            string animationPath = $"Data/animation{animationIndex}.mp4";
            videosQueue.Enqueue(animationPath);

            playNextVideo(true);
        }

        private void mePlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            playNextVideo();
        }

        private void playNextVideo(bool forceStop = false)
        {
            if (forceStop)
            {
                mePlayer.Stop();
            }

            timer.Stop();

            if (videosQueue.Count > 0)
            {
                string nextVideo = videosQueue.Dequeue();
                mePlayer.Source = new Uri(nextVideo, UriKind.Relative);
                mePlayer.Play();
                prevVideo = nextVideo;
            }
            else if (prevVideo != DefaultVideo)
            {
                mePlayer.Source = new Uri(DefaultVideo, UriKind.Relative);
                mePlayer.Play();
                prevVideo = DefaultVideo;
            }
            else
            {
                mePlayer.Position = new TimeSpan(0, 0, 1);
                mePlayer.Play();
            }

            timer.Start();
        }
    }
}
