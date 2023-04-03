using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;

namespace MeteoApp.Models
{
    public class CitySearchResult
    {
        public ObservableCollection<City> SearchResults { get; set; } = new();

        private RestClient _client;

        public CitySearchResult()
        {
            _client = new RestClient("https://api.openweathermap.org/geo/1.0/");
        }

        public async void SearchCity(string cityName)
        {
            SearchResults.Clear();

            RestRequest request = new RestRequest("direct");
            request.AddParameter("q", cityName);
            request.AddParameter("limit", 20);
            request.AddParameter("appid", "df66170c61febfcb26485d0240875d8b");

            RestResponse response = await _client.GetAsync(request);
            if (response.IsSuccessful)
            {
                JsonSerializerOptions options = new();
                options.PropertyNameCaseInsensitive = true;

                JsonDocument doc = JsonDocument.Parse(response.Content);
                JsonElement root = doc.RootElement;
                for (int i=0; i < root.GetArrayLength(); i++)
                {
                    City city = JsonSerializer.Deserialize<City>(root[i], options);
                    SearchResults.Add(city);
                }

            }
        }
    }
}
