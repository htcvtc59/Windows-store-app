using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CusControlCamera
{
    public sealed partial class MediaCamera : UserControl
    {

        public MediaCamera()
        {
            this.InitializeComponent();
            

        }
        public delegate void Photo();
        public event Photo buttonPhoTo;

        public delegate void PlayVideo();
        public event PlayVideo buttonPlayVideo;

        public delegate void StopVideo();
        public event StopVideo buttonStopVideo;



        public MediaCapture mediaCapPre
        {
            get { return preWebCam.Source; }
            set { preWebCam.Source = value; }
        }

        public string Status
        {
            get { return tbStatus.Text; }
            set { tbStatus.Text = value; }
        }


        private void btnPhoto_Click(object sender, RoutedEventArgs e)
        {
            buttonPhoTo();
        }

        private void btnPlayVideo_Click(object sender, RoutedEventArgs e)
        {
            buttonPlayVideo();
        }

        private void btnStopVideo_Click(object sender, RoutedEventArgs e)
        {
            buttonStopVideo();
        }
    }
}
