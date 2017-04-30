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

namespace CusControlMedia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            UserAudio.btnopenfile += UserAudio_btnopenfile;
            UserAudio.btnplay += UserAudio_btnplay;
            UserAudio.btnpause += UserAudio_btnpause;
            UserAudio.btnstop += UserAudio_btnstop;

        }
        private MediaElement media = new MediaElement();
        private void UserAudio_btnstop()
        {
            media.Stop();
        }

        private void UserAudio_btnpause()
        {
            media.Pause();
        }

        private void UserAudio_btnplay()
        {
            media.Play();
        }


        private async void UserAudio_btnopenfile()
        {
            FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".mp3");
            picker.FileTypeFilter.Add(".mp4");
            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                media.SetSource(stream, file.ContentType);

            }

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, object e)
        {
            if (media.AutoPlay == true && media.PlayToSource != null)
            {
                UserAudio.status = String.Format("{0} / {1}", media.Position.ToString(@"mm\:ss"), media.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                UserAudio.status = "No file";

        }
    }
}
