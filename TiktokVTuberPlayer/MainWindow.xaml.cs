using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using TiktokVTuberPlayer.Properties;

namespace TiktokVTuberPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string DefaultVideo = "Data/main.mp4";
        private Queue<string> videosQueue = new Queue<string>();
        private string prevVideo = DefaultVideo;
        private DispatcherTimer timer = new DispatcherTimer();
        private ITiktokService tiktokService;
        private VideoWindow videoWindow;
        private MediaElement mePlayer;
        private StringBuilder logText = new StringBuilder();
        private bool startListener = false;

        public MainWindow()
        {
            InitializeComponent();

            txtTiktokUsername.Text = Settings.Default.TiktokUsername;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            // Initialize tiktok listener
            tiktokService = new TiktokService(this);

            // Initialize video window
            videoWindow = new VideoWindow();
            videoWindow.Show();

            mePlayer = videoWindow.mePlayer;
            mePlayer.MediaEnded += mePlayer_MediaEnded;
            mePlayer.UnloadedBehavior = System.Windows.Controls.MediaState.Manual;
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

            lblMessageInQueue.Content = $"Animations in queue: {videosQueue.Count}";
        }

        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            videoWindow.ToogleFullscreen(videoWindow.FullScreen);
            videoWindow.FullScreen = !videoWindow.FullScreen;
        }

        public void EscShortcut(Object sender, ExecutedRoutedEventArgs e)
        {
            if (videoWindow.FullScreen)
            {
                videoWindow.ToogleFullscreen(true);
                videoWindow.FullScreen = false;
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

        private void btnStartListener_Click(object sender, RoutedEventArgs e)
        {
            if (startListener)
            {
                tiktokService.StopListenerAsync();
            }
            else
            {
                tiktokService.StartListener();
            }
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
                if (prevVideo == DefaultVideo)
                {
                    mePlayer.Stop();
                }
                else
                {
                    return;
                }
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

        public bool HasStartedTiktokListener
        {
            set
            {
                startListener = value;
                btnStartListener.Content = value ? "Stop Listener" : "Start Listener";

                if (value)
                {
                    MessageBox.Show("Started Tiktok listener");
                }
                else
                {
                    MessageBox.Show("Stopped Tiktok listener");
                }
            }
        }

        public string NotifyMessage
        {
            set
            {
                logText.AppendFormat($"{DateTime.Now} {value}" + Environment.NewLine);
                lblMessage.Text = logText.ToString();
                if (chkScrollToBottom.IsChecked == true)
                {
                    scrollViewer.ScrollToEnd();
                }
            }
        }

        public string TiktokUsername
        {
            get
            {
                return txtTiktokUsername.Text.Trim();
            }
        }

        private void btnClearLogs_Click(object sender, RoutedEventArgs e)
        {
            logText.Clear();
            lblMessage.Text = logText.ToString();
        }
    }
}
