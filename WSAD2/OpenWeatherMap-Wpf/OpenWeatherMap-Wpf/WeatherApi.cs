using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap_Wpf
{
    
    public class Coord
    {
        [JsonProperty("lon")]
        public double lon { get; set; }
        [JsonProperty("lat")]
        public double lat { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double temp { get; set; }
        [JsonProperty("pressure")]
        public double pressure { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }
        [JsonProperty("temp_min")]
        public double temp_min { get; set; }
        [JsonProperty("temp_max")]
        public double temp_max { get; set; }
        [JsonProperty("sea_level")]
        public double sea_level { get; set; }
        [JsonProperty("grnd_level")]
        public double grnd_level { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double speed { get; set; }
        [JsonProperty("deg")]
        public double deg { get; set; }
    }

    public class Clouds
    {
        [JsonProperty("all")]
        public int all { get; set; }
    }

    public class Sys
    {
        [JsonProperty("message")]
        public double message { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("sunrise")]
        public int sunrise { get; set; }
        [JsonProperty("sunset")]
        public int sunset { get; set; }
    }

    public class WeatherApi
    {
        [JsonProperty("coord")]
        public Coord coord { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
        [JsonProperty("base")]
        public string _base { get; set; }
        [JsonProperty("main")]
        public Main main { get; set; }
        [JsonProperty("wind")]
        public Wind wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds clouds { get; set; }
        [JsonProperty("dt")]
        public int dt { get; set; }
        [JsonProperty("sys")]
        public Sys sys { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("cod")]
        public int cod { get; set; }
    }
}
