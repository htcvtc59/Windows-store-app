using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CusControlMediaVideo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            mediaVideo.btnopen += MediaVideo_btnopen;
            mediaVideo.btnplay += MediaVideo_btnplay;
            mediaVideo.btnpause += MediaVideo_btnpause;
            mediaVideo.btnstop += MediaVideo_btnstop;
        }

        private void MediaVideo_btnstop()
        {
            mediaVideo.StopVideo();
        }

        private void MediaVideo_btnpause()
        {
            mediaVideo.PauseVideo();
        }

        private void MediaVideo_btnplay()
        {
            mediaVideo.PlayVideo();
        }

        private async void MediaVideo_btnopen()
        {
            FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".mp4");
            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                mediaVideo.MediaPlay(await file.OpenAsync(FileAccessMode.Read),file.ContentType);
            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, object e)
        {
            if (mediaVideo.autoplayMedia  == true && mediaVideo.PlayToSource != null)
            {
                mediaVideo.timeStatus = String.Format("{0} / {1}", mediaVideo.Position, mediaVideo.NaturalDuration);
            }
            else
                mediaVideo.timeStatus = "No file";
        }
    }
}
