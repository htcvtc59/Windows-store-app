using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Runtime.Serialization.Json;
using Windows.Storage.Streams;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ZingMp3App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            JsonZingMp3(Url);
        }
       //private static string Url = "http://mp3.zing.vn/html5xml/album-xml/ZGJmtLmimbHJQFWtkbctbmkn";
       private static string Url = "http://mp3.zing.vn/json/playlist/get-source/playlist/ZGJmtLmimbHJQFWtkbctbmkn";

        private async void JsonZingMp3(string url)
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(new Uri(url));
            var jsonmp3 = await response.Content.ReadAsStringAsync();

            //RootObject deserializedRoot = new RootObject();
            //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonmp3));
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedRoot.GetType());
            //deserializedRoot = ser.ReadObject(ms) as RootObject;
            

            RootObject2 deserializedRoot = new RootObject2();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonmp3));


            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootObject2));



            deserializedRoot = ser.ReadObject(ms) as RootObject2;


            int a = 1;



        }
    }
}
