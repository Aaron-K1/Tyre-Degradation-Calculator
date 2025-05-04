using Newtonsoft.Json;

namespace Renault_F1_Application.Types.OpenWeather
{
    public class GeocodeResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lat")]
        public double latitude { get; set; }
        [JsonProperty("lon")]
        public double longitude { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
    }
}
