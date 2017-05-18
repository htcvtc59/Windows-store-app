using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Windows.Storage.Streams;
using Windows.Storage;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HttpDownload
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            string content = await client.GetStringAsync(new Uri(txtUrl.Text, UriKind.Absolute));
            txtContent.Text = content;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.Web.Http.HttpClient client = new Windows.Web.Http.HttpClient();
            IInputStream inputStream = await client.GetInputStreamAsync(new Uri(txtUrl.Text, UriKind.Absolute));
            Stream webStream = inputStream.AsStreamForRead();
            FileSavePicker picker = new FileSavePicker();
            picker.FileTypeChoices.Add("Text", new List<string>() { ".txt", ".html" });
            picker.FileTypeChoices.Add("Binary", new List<string>() { ".txt", ".dat" });
            StorageFile file = await picker.PickSaveFileAsync();
            Stream fileStream = await file.OpenStreamForWriteAsync();
            await webStream.CopyToAsync(fileStream);
            await new MessageDialog("File Saved").ShowAsync();

        }
    }
}
