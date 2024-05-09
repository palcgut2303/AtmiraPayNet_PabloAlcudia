using AtmiraPayNet.Shared;

namespace AtmiraPayNet.Client.Services
{
    public interface ICountryService
    {
        Task<List<CountryInfo>> GetCountries();
    }
}
