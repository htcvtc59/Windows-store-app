using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CameraPhoto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaCapture takePhotoManager = null;
        public MainPage()
        {
            this.InitializeComponent();
            takePhotoManager = new MediaCapture();
        }

        private async void btnPreview_Click(object sender, RoutedEventArgs e)
        {
            await takePhotoManager.InitializeAsync();
            PhotoPreview.Source = takePhotoManager;
            await takePhotoManager.StartPreviewAsync();

        }

        private async void btnTake_Click(object sender, RoutedEventArgs e)
        {
            ImageEncodingProperties imgFormat = ImageEncodingProperties.CreateJpeg();
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("Photo.jpg", CreationCollisionOption.ReplaceExisting);
            await takePhotoManager.CapturePhotoToStorageFileAsync(imgFormat, file);


        }

        private async void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            MediaEncodingProfile video = MediaEncodingProfile.CreateMp4(VideoEncodingQuality.HD720p);

            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("Video.mp4", CreationCollisionOption.ReplaceExisting);

            await takePhotoManager.StartRecordToStorageFileAsync(video, file);


        }

        private async void btnVideoStop_Click(object sender, RoutedEventArgs e)
        {
            await takePhotoManager.StopRecordAsync();
        }
    }
}
