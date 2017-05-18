using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.PlayTo;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CusControlMediaVideo
{
    public sealed partial class MediaVideo : UserControl
    {
        public MediaVideo()
        {
            this.InitializeComponent();
        }
        public delegate void OpenFile();
        public event OpenFile btnopen;
        public delegate void Play();
        public event Play btnplay;
        public delegate void Pause();
        public event Pause btnpause;
        public delegate void Stop();
        public event Stop btnstop;
        public string timeStatus
        {
            get { return tbTimeStatus.Text; }
            set { tbTimeStatus.Text = value; }
        }
        public Uri sourceMedia
        {
            get { return mvideo.Source; }
            set { mvideo.Source = value; }
        }

        public bool autoplayMedia
        {
            get { return mvideo.AutoPlay; }
            set { mvideo.AutoPlay = value; }
        }

        public PlayToSource PlayToSource
        {
            get { return mvideo.PlayToSource; }
        }

        public string Position
        {
            get { return mvideo.Position.ToString(@"mm\:ss"); }
        }
        public string NaturalDuration
        {
            get { return mvideo.NaturalDuration.TimeSpan.ToString(@"mm\:ss"); }
        }

        public void MediaPlay(IRandomAccessStream stream, string type)
        {
            mvideo.SetSource(stream, type);
        }

        public void PlayVideo()
        {
            mvideo.Play();
        }
        public void PauseVideo()
        {
            mvideo.Pause();
        }
        public void StopVideo()
        {
            mvideo.Stop();
        }


        private void btnOpenFileVideo_Click(object sender, RoutedEventArgs e)
        {
            btnopen();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnplay();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            btnpause();
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            btnstop();
        }
    }
}
