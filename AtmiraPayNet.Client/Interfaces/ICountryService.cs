using AtmiraPayNet.Shared;

namespace AtmiraPayNet.Client.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryInfo>> GetCountries();
    }
}
