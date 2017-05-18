using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CusControlMedia
{
    public sealed partial class MediaAudio : UserControl
    {
        public MediaAudio()
        {
            this.InitializeComponent();
        }
        public delegate void OpenFile();
        public event OpenFile btnopenfile;

        public delegate void Play();
        public event Play btnplay;

        public delegate void Pause();
        public event Pause btnpause;

        public delegate void Stop();
        public event Stop btnstop;



        public string status
        {
            get { return tbStatus.Text; }
            set { tbStatus.Text = value; }
        }



        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            btnopenfile();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnplay();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            btnpause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            btnstop();
        }
    }
}
