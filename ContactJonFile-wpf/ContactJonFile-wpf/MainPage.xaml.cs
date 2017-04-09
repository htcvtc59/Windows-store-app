using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ContactJonFile_wpf
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            //addJsonNewTon();
             writeJsonAsync();



        }


        private async void writeJsonAsync()
        {
            List<contact> myContact = new List<contact>();
            myContact.Add(new contact() { name = "12a", phone = "01321", group = "A" });
            myContact.Add(new contact() { name = "24a", phone = "0GHD21", group = "B" });
            myContact.Add(new contact() { name = "14b", phone = "054521", group = "C" });

            
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("data.json",
                          CreationCollisionOption.OpenIfExists);
            
            using (Stream stream = await file.OpenStreamForWriteAsync())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<contact>));
                serializer.WriteObject(stream, myContact);
                await stream.FlushAsync();
                await new MessageDialog("Data success").ShowAsync();
            }
            

        }

        private async void addJsonNewTon()
        {
            contact cont = new contact();
            cont.name = txtName.Text;
            cont.phone = txtPhone.Text;
            cont.group = cbbGroup.SelectionBoxItem.ToString();
            string json = JsonConvert.SerializeObject(cont);
            var local = ApplicationData.Current.LocalFolder;
            var file = await local.CreateFileAsync("contact.json", CreationCollisionOption.OpenIfExists);

            using (IRandomAccessStream ms = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (DataWriter writer = new DataWriter(ms))
                {
                    writer.WriteString(json);
                    await writer.StoreAsync();
                    await new MessageDialog("Data success").ShowAsync();
                    txtName.Text = "";
                    txtPhone.Text = "";
                    cbbGroup.SelectedIndex = -1;
                }

            }


        }



        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(View));
            }
        }
    }
}
