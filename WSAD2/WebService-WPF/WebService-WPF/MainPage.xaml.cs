using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WebService_WPF
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            cbbLoad();
        }
        public async void cbbLoad() {
            List<ServiceReference.Dictionary> lstDic = new List<ServiceReference.Dictionary>(); 
            ServiceReference.DictServiceSoapClient client = new ServiceReference.DictServiceSoapClient();
            ServiceReference.Dictionary[] result = await client.DictionaryListAsync();
            foreach (var item in result)
            {
               
                lstDic.Add(item);
            }
            comboBox.ItemsSource = lstDic;


        }

        private async void btnIdWord_Click(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text;
            ServiceReference.DictServiceSoapClient client = new ServiceReference.DictServiceSoapClient();
            string keyid = (comboBox.SelectedItem as ServiceReference.Dictionary).Id;
            ServiceReference.WordDefinition result = await client.DefineInDictAsync(keyid, word);
            txtContent.Document.SetText(Windows.UI.Text.TextSetOptions.None, result.Definitions[0].WordDefinition);
        }

        private async void btnDic_Click(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text;
            ServiceReference.DictServiceSoapClient client = new ServiceReference.DictServiceSoapClient();
            ServiceReference.WordDefinition result = await client.DefineAsync(word);

            string def = "";
            foreach (var item in result.Definitions)
            {
                def += item.WordDefinition;
            }
            //result.Definitions[0].WordDefinition
            txtContent.Document.SetText(Windows.UI.Text.TextSetOptions.None, def);
        }

        private async void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ServiceReference.DictServiceSoapClient client = new ServiceReference.DictServiceSoapClient();
            string keyid = (comboBox.SelectedItem as ServiceReference.Dictionary).Id;

            string result = await client.DictionaryInfoAsync(keyid);
            txtContent.Document.SetText(Windows.UI.Text.TextSetOptions.None, result);
        }
    }
}
