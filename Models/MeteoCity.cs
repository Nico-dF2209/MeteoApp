using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace MeteoApp.Models
{
    public class MeteoCity
    {
        public ObservableCollection<Meteo> SearchMeteoo { get; set; } = new();

        private RestClient _restClient;

        public MeteoCity(float lat, float lon)
        {
            _restClient = new RestClient("https://api.openweathermap.org/data/2.5/");
            SearchMeteo(lat, lon);
        }

        public async void SearchMeteo(float latitude, float longitude)
        {
            SearchMeteoo.Clear();

            RestRequest request = new RestRequest("wheather");
            request.AddParameter("lat", latitude);
            request.AddParameter("lon", longitude);
            request.AddParameter("appid", "df66170c61febfcb26485d0240875d8b");
            request.AddParameter("units", "metric");

            RestResponse response = await _restClient.GetAsync(request);

            if (response.IsSuccessful)
            {
                JsonSerializerOptions options = new();
                options.PropertyNameCaseInsensitive = true;

                JsonDocument doc = JsonDocument.Parse(response.Content);
                JsonElement root = doc.RootElement;
                Meteo meteo = JsonSerializer.Deserialize<Meteo>(root, options);
                SearchMeteoo.Add(meteo);
            }
            
        }
    }
}
