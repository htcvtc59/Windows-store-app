using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml.Media.Imaging;
using System.Text.RegularExpressions;
using Windows.ApplicationModel.Background;
using Windows.UI.Xaml;
using System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml.Data;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OpenWeatherMap_Wpf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            getCurrent();
            SevenDays();
            chartTemp();
        }

        public class ChartDay
        {
            public string CName { get; set; }
            public double CTemp { get; set; }

        }
        private async void chartTemp()
        {
            WeatherDays weaDays = await weathersD();
            List<ChartDay> chartday = new List<ChartDay>();
            chartday.Add(new ChartDay() { CName = nameDays(1), CTemp = Math.Round((weaDays.list[1].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(2), CTemp = Math.Round((weaDays.list[2].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(3), CTemp = Math.Round((weaDays.list[3].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(4), CTemp = Math.Round((weaDays.list[4].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(5), CTemp = Math.Round((weaDays.list[5].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(6), CTemp = Math.Round((weaDays.list[6].temp.day - 273.1), 2) });
            chartday.Add(new ChartDay() { CName = nameDays(7), CTemp = Math.Round((weaDays.list[7].temp.day - 273.1), 2) });

            (LineChart.Series[0] as LineSeries).ItemsSource = chartday;

        }

        private async void SevenDays()
        {
            WeatherDays weaDays = await weathersD();
            //add Image 


            string imgD1 = "http://openweathermap.org/img/w/" + weaDays.list[1].weather[0].icon + ".png";
            string imgD2 = "http://openweathermap.org/img/w/" + weaDays.list[2].weather[0].icon + ".png";
            string imgD3 = "http://openweathermap.org/img/w/" + weaDays.list[3].weather[0].icon + ".png";
            string imgD4 = "http://openweathermap.org/img/w/" + weaDays.list[4].weather[0].icon + ".png";
            string imgD5 = "http://openweathermap.org/img/w/" + weaDays.list[5].weather[0].icon + ".png";
            string imgD6 = "http://openweathermap.org/img/w/" + weaDays.list[6].weather[0].icon + ".png";
            string imgD7 = "http://openweathermap.org/img/w/" + weaDays.list[7].weather[0].icon + ".png";
            imgDay1.Source = new BitmapImage(new Uri(imgD1));
            imgDay2.Source = new BitmapImage(new Uri(imgD2));
            imgDay3.Source = new BitmapImage(new Uri(imgD3));
            imgDay4.Source = new BitmapImage(new Uri(imgD4));
            imgDay5.Source = new BitmapImage(new Uri(imgD5));
            imgDay6.Source = new BitmapImage(new Uri(imgD6));
            imgDay7.Source = new BitmapImage(new Uri(imgD7));
            //Add Temp Day
            tbDTemp1.Text = Math.Round((weaDays.list[1].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp2.Text = Math.Round((weaDays.list[2].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp3.Text = Math.Round((weaDays.list[3].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp4.Text = Math.Round((weaDays.list[4].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp5.Text = Math.Round((weaDays.list[5].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp6.Text = Math.Round((weaDays.list[6].temp.day - 273.1), 2).ToString() + " ℃";
            tbDTemp7.Text = Math.Round((weaDays.list[7].temp.day - 273.1), 2).ToString() + " ℃";
            //Add Temp Night
            tbNTemp1.Text = Math.Round((weaDays.list[1].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp2.Text = Math.Round((weaDays.list[2].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp3.Text = Math.Round((weaDays.list[3].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp4.Text = Math.Round((weaDays.list[4].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp5.Text = Math.Round((weaDays.list[5].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp6.Text = Math.Round((weaDays.list[6].temp.night - 273.1), 2).ToString() + " ℃";
            tbNTemp7.Text = Math.Round((weaDays.list[7].temp.night - 273.1), 2).ToString() + " ℃";
            //Weather Description
            tbWDes1.Text = weaDays.list[1].weather[0].description;
            tbWDes2.Text = weaDays.list[2].weather[0].description;
            tbWDes3.Text = weaDays.list[3].weather[0].description;
            tbWDes4.Text = weaDays.list[4].weather[0].description;
            tbWDes5.Text = weaDays.list[5].weather[0].description;
            tbWDes6.Text = weaDays.list[6].weather[0].description;
            tbWDes7.Text = weaDays.list[7].weather[0].description;
            //Wind Speed
            tbWindS1.Text = weaDays.list[1].speed.ToString() + " m/s";
            tbWindS2.Text = weaDays.list[2].speed.ToString() + " m/s";
            tbWindS3.Text = weaDays.list[3].speed.ToString() + " m/s";
            tbWindS4.Text = weaDays.list[4].speed.ToString() + " m/s";
            tbWindS5.Text = weaDays.list[5].speed.ToString() + " m/s";
            tbWindS6.Text = weaDays.list[6].speed.ToString() + " m/s";
            tbWindS7.Text = weaDays.list[7].speed.ToString() + " m/s";
            //Name Day
            tbDayN1.Text = nameDays(1);
            tbDayN2.Text = nameDays(2);
            tbDayN3.Text = nameDays(3);
            tbDayN4.Text = nameDays(4);
            tbDayN5.Text = nameDays(5);
            tbDayN6.Text = nameDays(6);
            tbDayN7.Text = nameDays(7);

        }
        private string nameDays(int x)
        {
            DateTime daynnow = DateTime.Now;
            DateTime dayname = daynnow.AddDays(x);
            return dayname.DayOfWeek.ToString();
        }


        private async void getCurrent()
        {
            WeatherApi rootobj = await parseJsonObj();


            //Address
            GoogleMapApi api = await locationGoogleApi();
            //string address = api.results[0].formatted_address;
            AddressComponent city = api.results[0].address_components[3];
            AddressComponent country = api.results[0].address_components[4];
            string address = city.long_name + ", " + country.long_name;
            tbAddress.Text = address;

            //Temperature
            Main main = rootobj.main;
            //string mintemp = "Thấp " + ((int)(main.temp_min - 273.1)).ToString() + "℃ ";
            //string maxtemp = "Cao " + ((int)(main.temp_max - 273.1)).ToString() + "℃";
            // string maintemp = ((int)(main.temp - 273.1)).ToString() + "°";
            string maintemp = Math.Round((main.temp - 273.1), 2).ToString() + "°";

            //tbtempMain.Text = mintemp + maintemp + maxtemp;
            tbtempMain.Text = maintemp;

            //Weather Descreption
            string wetherdes = rootobj.weather[0].description;
            string[] word = wetherdes.Split(' ');

            string wedes = null;
            for (int i = 0; i < word.Length; i++)
            {
                wedes += Regex.Replace(word[i], "^[a-z]", m => m.Value.ToUpper()) + " ";
            }
            tbWeatherDes.Text = wedes;
            //Feels Like
            tbFeelsLike.Text = "Feels Like " + maintemp;
            //Humidity 
            tbHumidity.Text = "Humidity " + rootobj.main.humidity.ToString() + "%";
            //Atmospheric pressure
            tbAtmosPressure.Text = "Pressure " + Math.Round((rootobj.main.grnd_level * 0.000986923267), 2).ToString() + "atm";
            //Wind
            double windeg = rootobj.wind.deg;
            string windegStr = (0 <= windeg && windeg < 22.5) ? "North-northeast" : (22.5 <= windeg && windeg < 45) ? "Northeast" :
                (45 <= windeg && windeg < 67.5) ? "East-northeast" :
                (67.5 <= windeg && windeg < 90) ? "East" : (90 <= windeg && windeg < 112.5) ? "East-southeast" :
                (112.5 <= windeg && windeg < 135) ? "Southeast" :
                (135 <= windeg && windeg < 157.5) ? "South-southeast" : (157.5 <= windeg && windeg < 180) ? "South" :
                (180 <= windeg && windeg < 202.5) ? "South-southwest" :
                (202.5 <= windeg && windeg < 225) ? "Southwest" : (225 <= windeg && windeg < 247.5) ? "West-southwest" :
                (247.5 <= windeg && windeg < 270) ? "West" :
                (270 <= windeg && windeg < 292.5) ? "West-northwest" : (292.5 <= windeg && windeg < 315) ? "Northwest" :
                (315 <= windeg && windeg < 337.5) ? "North-northwest" :
                "North";


            tbWind.Text = "Wind speed " + Math.Round((rootobj.wind.speed * 3.6), 2) + "km/h" + "\n" +
             "          " + windegStr + " (" + rootobj.wind.deg + "°" + ")";
            //Clouds
            tbCloud.Text = "Cloudiness " + rootobj.clouds.all + "%";
            //Sunrise
            DateTime daterise = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            daterise = daterise.AddSeconds(rootobj.sys.sunrise).ToLocalTime();
            tbSunrise.Text = "Sunrise " + daterise.Hour + ":" + daterise.Minute;
            //Sunset
            DateTime dateset = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateset = dateset.AddSeconds(rootobj.sys.sunset).ToLocalTime();
            tbSunset.Text = "Sunset " + dateset.Hour + ":" + dateset.Minute;


            //Icon current weather
            string icon = rootobj.weather[0].icon;
            string httpicon = "http://openweathermap.org/img/w/" + icon + ".png";
            iconWeatherCurrent.Source = new BitmapImage(new Uri(httpicon));

        }





        private static string YOUR_API_KEY = "AIzaSyCL-hmg8adVUSWbL4OiVosP9IyTCzxEEO4";
        private async Task<GoogleMapApi> locationGoogleApi()
        {
            //get location lat and lon
            Geolocator gl = new Geolocator();
            Geoposition gp = await gl.GetGeopositionAsync();

            string country = gp.CivicAddress.Country;
            string latitude = gp.Coordinate.Latitude.ToString();
            string longitude = gp.Coordinate.Longitude.ToString();
            //get object 
            HttpClient client = new HttpClient();
            string res = await client.GetStringAsync("https://maps.googleapis.com/maps/api/geocode/json?latlng=" + latitude + "," + longitude + "&key=" + YOUR_API_KEY);
            GoogleMapApi googleapi = JsonConvert.DeserializeObject<GoogleMapApi>(res);

            return googleapi;
        }

        private static string APPID = "152386ea138e2ffdcf59f2e2e70f7ac2";

        private async Task<WeatherDays> weathersD()
        {
            WeatherApi root = await parseJsonObj();
            int idcity = root.id;
            HttpClient web = new HttpClient();
            string response = await web.GetStringAsync(" http://api.openweathermap.org/data/2.5/forecast/daily?APPID=" + APPID + "&id=" + idcity + "&cnt=8");
            WeatherDays weatherDay = JsonConvert.DeserializeObject<WeatherDays>(response);
            return weatherDay;
        }




        private async Task<WeatherApi> parseJsonObj()
        {
            GoogleMapApi cityapi = await locationGoogleApi();
            string city = "";
            AddressComponent address = cityapi.results[0].address_components[3];
            city = address.short_name;
            //Short city
            Geolocator gl = new Geolocator();
            Geoposition gp = await gl.GetGeopositionAsync();
            string country = gp.CivicAddress.Country;
            //VN
            HttpClient web = new HttpClient();
            string response = await web.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?APPID=" + APPID + "&q=" + city + "," + country);
            WeatherApi rootobj = JsonConvert.DeserializeObject<WeatherApi>(response);
            return rootobj;

        }








        //Parse Json Second
        private async void parseJsonSecond()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("http://api.openweathermap.org/data/2.5/weather?APPID=" + APPID + "&q=" + "Ha Noi");
            HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();

            WeatherApi rootobj = JsonConvert.DeserializeObject<WeatherApi>(mycontent);
            Coord coord = rootobj.coord;

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            getCurrent();
            SevenDays();
            chartTemp();
        }
    }
}
