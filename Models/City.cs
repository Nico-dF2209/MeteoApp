using System.Text.Json.Serialization;

namespace MeteoApp.Models
{
    public class City
    {
        [JsonPropertyName("name")]
        public string CityName { get; set; }
        [JsonPropertyName("country")]
        public string CountryCode { get; set; }
        [JsonPropertyName("lat")]
        public float Latitude { get; set; }
        [JsonPropertyName("lon")]
        public float Longitude { get; set; }
        



    }
}
