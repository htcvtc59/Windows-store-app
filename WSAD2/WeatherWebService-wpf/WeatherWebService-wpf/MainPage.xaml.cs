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

namespace WeatherWebService_wpf
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

        private async void btnWeather_Click(object sender, RoutedEventArgs e)
        {
            string city = txtCity.Text;
            string country = txtCountry.Text;
            ServiceReference.GlobalWeatherSoapClient client = new ServiceReference.GlobalWeatherSoapClient();
            string content = await client.GetWeatherAsync(city, country);
            //string content = await client.GetCitiesByCountryAsync(country);
            txtContent.Document.SetText(Windows.UI.Text.TextSetOptions.None, content);


        }
    }
}
