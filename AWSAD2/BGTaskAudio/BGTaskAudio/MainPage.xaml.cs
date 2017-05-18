using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BGTaskAudio
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            picker.FileTypeFilter.Add(".mp3");
            picker.FileTypeFilter.Add(".wma");
            var file = await picker.PickSingleFileAsync();
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            myPlayer.SetSource(stream,file.ContentType);
            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            myPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            myPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            myPlayer.Stop();
        }
    }
}
