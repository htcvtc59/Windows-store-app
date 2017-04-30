using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CusControlCamera
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaCapture mediaCap = null;
        Stopwatch sw = new Stopwatch();
        public MainPage()
        {
            this.InitializeComponent();
            mediaCapture.buttonPhoTo += MediaCapture_buttonPhoTo;
            mediaCapture.buttonPlayVideo += MediaCapture_buttonPlayVideo;
            mediaCapture.buttonStopVideo += MediaCapture_buttonStopVideo;
            mediaCap = new MediaCapture();

            Preview();
        }

        private async void MediaCapture_buttonStopVideo()
        {
            await mediaCap.StopRecordAsync();
            timer.Stop();
            sw.Stop();
        }

        private async void MediaCapture_buttonPlayVideo()
        {
            MediaEncodingProfile video = MediaEncodingProfile.CreateMp4(VideoEncodingQuality.Auto);

            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("Video.mp4", CreationCollisionOption.ReplaceExisting);

            await mediaCap.StartRecordToStorageFileAsync(video, file);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            sw.Start();
        }
        private DispatcherTimer timer;
    
        private void Timer_Tick(object sender, object e)
        {
            TimeSpan ts = sw.Elapsed;

            mediaCapture.Status = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

        }

        private async void Preview()
        {
            // to stream from webcam
            await mediaCap.InitializeAsync();

            // Start capture preview.                
            mediaCapture.mediaCapPre = mediaCap;
            await mediaCap.StartPreviewAsync();
        }
        private async void MediaCapture_buttonPhoTo()
        {
            ImageEncodingProperties imgFormat = ImageEncodingProperties.CreateJpeg();
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("Photo.jpg", CreationCollisionOption.ReplaceExisting);
            await mediaCap.CapturePhotoToStorageFileAsync(imgFormat, file);
            mediaCapture.Status = "Photo";
        }
    }
}
