using Wipro_DFA_CountryStates_AutoMapper.EntityFramework;
using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly Wipro29082024Context countryDbContext;
        private readonly IStateRepository stateRepository;
        public CountryRepository(Wipro29082024Context _countryDbContext,
            IStateRepository _stateRepository)
        {
            countryDbContext = _countryDbContext;
            stateRepository = _stateRepository;
        }

        public void DeleteCountry(int id)
        {
            Country country = countryDbContext.Country.SingleOrDefault(c => c.CountryId == id);
            countryDbContext.Country.Remove(country);
            countryDbContext.SaveChanges();
        }

        public IEnumerable<Country> GetCountries()
        {
            return countryDbContext.Country.ToList();
        }

        public Country GetCountry(int id)
        {
            return countryDbContext.Country.FirstOrDefault(c => c.CountryId == id);
        }

        public void InsertCountry(Country country)
        {
            country.States = stateRepository.GetStates().Where(s => s.CountryId == country.CountryId).ToList();
            countryDbContext.Country.Add(country);
            countryDbContext.SaveChanges();
        }

        public void UpdateCountry(Country country)
        {
            countryDbContext.Country.Update(country);
            countryDbContext.SaveChanges();
        }
    }
}
