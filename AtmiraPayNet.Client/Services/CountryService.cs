using AtmiraPayNet.Shared;
using System.Text.Json;

namespace AtmiraPayNet.Client.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CountryInfo>> GetCountries()
        {
            var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all?fields=name,currencies,cca2");
            if (response.IsSuccessStatusCode)
            {
                var jsonRepos = await response.Content.ReadAsStringAsync();
                var repos = System.Text.Json.JsonSerializer.Deserialize<List<CountryInfo>>(jsonRepos);
                return repos;
            }
            else
            {
                return null;
            }
        }

    }
}
