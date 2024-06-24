using System;
using System.Windows;
using System.Windows.Input;

namespace TiktokVTuberPlayer
{
    /// <summary>
    /// Interaction logic for VideoWindow.xaml
    /// </summary>
    public partial class VideoWindow : Window
    {
        private bool fullscreen = false;
        public bool FullScreen
        {
            get
            {
                return fullscreen;
            }

            set
            {
                fullscreen = value;
            }
        }

        public VideoWindow()
        {
            InitializeComponent();
        }

        public void ToogleFullscreen(bool isFullscreen)
        {
            if (!isFullscreen)
            {
                this.gridRoot.Children.Remove(mePlayer);
                this.Content = mePlayer;
                this.WindowStyle = WindowStyle.None;
                //this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.Content = this.gridRoot;
                this.gridRoot.Children.Add(mePlayer);
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                //this.WindowState = WindowState.Normal;
            }
        }

        public void EscShortcut(Object sender, ExecutedRoutedEventArgs e)
        {
            if (fullscreen)
            {
                ToogleFullscreen(true);
                fullscreen = false;
            }
        }
    }
}
