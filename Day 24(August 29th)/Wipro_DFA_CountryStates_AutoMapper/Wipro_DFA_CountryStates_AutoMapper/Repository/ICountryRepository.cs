using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int id);
        void InsertCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(int id);
    }
}
