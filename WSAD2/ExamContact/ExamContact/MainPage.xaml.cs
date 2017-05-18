using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExamContact
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
        private string nimage = "";
        List<Contact> lstCont = new List<Contact>();
        private async void btnBrowser_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation =
                Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            var file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                Contact cont = new Contact() { nameimage = file.Name };
                tbImage.Text = file.Path;
                lstCont.Add(cont);
                var local = ApplicationData.Current.LocalFolder;
                await local.CreateFolderAsync("Data", CreationCollisionOption.OpenIfExists);
                StorageFolder folder = await local.GetFolderAsync("Data");
                await file.CopyAsync(folder);
            }



        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            writeJson();
        }

        private const string JSONFILENAME = @"\Data\contact.json";
        public async void writeJson()
        {
            //List Buy Car
            List<Contact> myContact = new List<Contact>();
            myContact.Add(new Contact() { name = tbName.Text, number = tbNumber.Text, group = cbbGroup.SelectionBoxItem.ToString(), image = tbImage.Text,nameimage=lstCont[0].nameimage});
            //add more than car
            string content = String.Empty;
            await ApplicationData.Current.LocalFolder.CreateFileAsync(JSONFILENAME, CreationCollisionOption.OpenIfExists);
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
            {
                content = await reader.ReadToEndAsync();
                if (content.Length != 0)
                {
                    DataContractJsonSerializer seri = new DataContractJsonSerializer(typeof(List<Contact>));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content));

                    List<Contact> buy = (List<Contact>)seri.ReadObject(ms);
                    myContact.AddRange(buy);
                    await ms.FlushAsync();
                }


            }
            //write
            var serializer = new DataContractJsonSerializer(typeof(List<Contact>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(
                JSONFILENAME,
                CreationCollisionOption.ReplaceExisting))
            {
                serializer.WriteObject(stream, myContact);
            }

            await new MessageDialog("Write success").ShowAsync();

        }

        private void btnNavigate_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(SearchContact));
            }
        }
    }
}
