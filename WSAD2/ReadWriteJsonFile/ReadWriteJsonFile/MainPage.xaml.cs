using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
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

namespace ReadWriteJsonFile
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

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //await writeXMLAsync();
            await writeJsonAsync();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(VContact));
            }
        }

        private const string XMLFILENAME = "data.xml";
        private const string JSONFILENAME = "data.json";
        private List<Contact> buildObjectGraph()
        {
            var myContact = new List<Contact>();

            myContact.Add(new Contact() { Name = "abc", Phone = "0123", Group = "A" });
            myContact.Add(new Contact() { Name = "xyz", Phone = "3123", Group = "B" });
            myContact.Add(new Contact() { Name = "asd", Phone = "5658", Group = "C" });

            return myContact;
        }
        private async Task writeJsonAsync()
        {

            var myContact = buildObjectGraph();

            var serializer = new DataContractJsonSerializer(typeof(List<Contact>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(
                          JSONFILENAME,
                          CreationCollisionOption.ReplaceExisting))
            {
                serializer.WriteObject(stream, myContact);
            }

            await new MessageDialog("Data success").ShowAsync();
            txtName.Text = "";
            txtPhone.Text = "";
            cbbGroup.SelectedIndex = -1;


        }





    }
}
