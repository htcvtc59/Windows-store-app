using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap_Wpf
{

    public class CoordDays
    {
        [JsonProperty("lon")]
        public double lon { get; set; }
        [JsonProperty("lat")]
        public double lat { get; set; }
    }

    public class City
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("coord")]
        public CoordDays coord { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("population")]
        public int population { get; set; }
    }

    public class Temp
    {
        [JsonProperty("day")]
        public double day { get; set; }
        [JsonProperty("min")]
        public double min { get; set; }
        [JsonProperty("max")]
        public double max { get; set; }
        [JsonProperty("night")]
        public double night { get; set; }
        [JsonProperty("eve")]
        public double eve { get; set; }
        [JsonProperty("morn")]
        public double morn { get; set; }
    }

    public class WeatherDay
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

    public class List
    {
        [JsonProperty("dt")]
        public int dt { get; set; }
        [JsonProperty("temp")]
        public Temp temp { get; set; }
        [JsonProperty("pressure")]
        public double pressure { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }
        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }
        [JsonProperty("speed")]
        public double speed { get; set; }
        [JsonProperty("deg")]
        public int deg { get; set; }
        [JsonProperty("clouds")]
        public int clouds { get; set; }
        [JsonProperty("rain")]
        public double? rain { get; set; }
    }

    public class WeatherDays
    {
        [JsonProperty("city")]
        public City city { get; set; }
        [JsonProperty("cod")]
        public string cod { get; set; }
        [JsonProperty("message")]
        public double message { get; set; }
        [JsonProperty("cnt")]
        public int cnt { get; set; }
        [JsonProperty("list")]
        public List<List> list { get; set; }
    }

}
