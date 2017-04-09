using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap_Wpf
{

    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public string long_name { get; set; }
        [JsonProperty("short_name")]
        public string short_name { get; set; }
        [JsonProperty("types")]
        public List<string> types { get; set; }
    }

    public class Northeast
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Southwest
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Bounds
    {
        [JsonProperty("northeast")]
        public Northeast northeast { get; set; }
        [JsonProperty("southwest")]
        public Southwest southwest { get; set; }
    }

    public class Location
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Northeast2
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Southwest2
    {
        [JsonProperty("lat")]
        public double lat { get; set; }
        [JsonProperty("lng")]
        public double lng { get; set; }
    }

    public class Viewport
    {
        [JsonProperty("northeast")]
        public Northeast2 northeast { get; set; }
        [JsonProperty("southwest")]
        public Southwest2 southwest { get; set; }
    }

    public class Geometry
    {
        [JsonProperty("bounds")]
        public Bounds bounds { get; set; }
        [JsonProperty("location")]
        public Location location { get; set; }
        [JsonProperty("location_type")]
        public string location_type { get; set; }
        [JsonProperty("viewport")]
        public Viewport viewport { get; set; }
    }

    public class Result
    {
        [JsonProperty("address_components")]
        public List<AddressComponent> address_components { get; set; }
        public string formatted_address { get; set; }
        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }
        [JsonProperty("place_id")]
        public string place_id { get; set; }
        [JsonProperty("types")]
        public List<string> types { get; set; }
    }

    public class GoogleMapApi
    {
        [JsonProperty("results")]
        public List<Result> results { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }

}
