using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
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

namespace ReadRss
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            readRss();
        }
        string uri = "http://vnexpress.net/rss/the-thao.rss";
        private void readRss()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(uri).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            var items = from Rss in XElement.Parse(content).Descendants("item")
                        select new Rss
                        {
                            title = Rss.Element("title").Value,
                            des = Rss.Element("description").Value
                            
                            
                       };


            listview.ItemsSource = items;
            
        }


    }
}
