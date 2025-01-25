using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_DFA_CountryStates_AutoMapper.DTO;
using Wipro_DFA_CountryStates_AutoMapper.Models;
using Wipro_DFA_CountryStates_AutoMapper.Repository;

namespace Wipro_DFA_CountryStates_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;
        public CountryController(ICountryRepository _countryRepository, IMapper _mapper, IStateRepository _stateRepository)
        {
            countryRepository = _countryRepository;
            stateRepository = _stateRepository;
            mapper = _mapper;
        }

        Country country = new Country();
        State state = new State();

        [HttpPost("CreateCountry")]
        public ActionResult CreateCountry(CreateCountryDTO countryDTO)
        {
            //countryDTO.States = stateRepository.GetStates().Where(c => c.CountryId == country.CountryId).ToList();
            countryRepository.InsertCountry(mapper.Map<Country>(countryDTO));
            return Ok();
        }

        [HttpGet("GetAllCountries")]
        public ActionResult GetAllCountries()
        {
            return Ok(countryRepository.GetCountries().ToList());
        }

        [HttpGet("SearchCountryById")]
        public ActionResult SearchCountry(int countryId)
        {
            return Ok(countryRepository.GetCountry(countryId));
        }

        [HttpPut("UpdateCountry")]
        public ActionResult UpdateCountry(UpdateCountryDTO countryDTO)
        {
            countryRepository.UpdateCountry(mapper.Map<Country>(countryDTO));
            return Ok();
        }

        [HttpDelete("DeleteCountry")]
        public ActionResult DeleteCountry(int countryId)
        {
            countryRepository.DeleteCountry(countryId);
            return Ok();
        }

        [HttpGet("GetAllCountriesWithState")]
        public IActionResult GetAllCountriesWithState()
        {
            List<CountryStateLstDTO> countryStateLstDTOs = new List<CountryStateLstDTO>();
            var lstCountry = countryRepository.GetCountries().ToList();

            foreach(var country in lstCountry)
            {
                var countryItem = country.CountryId;
                var lstState = stateRepository.GetStates().Where(c => c.CountryId ==  countryItem).ToList();
                CountryStateLstDTO countryStateLstDTO = new CountryStateLstDTO();
                countryStateLstDTO.CountryId = country.CountryId;
                countryStateLstDTO.CountryName = country.CountryName;
                countryStateLstDTO.LstState = new List<StateDTO>();
                foreach(var state in lstState)
                {
                    StateDTO stateDTO = new StateDTO();
                    stateDTO.StateId = state.StateId;
                    stateDTO.StateName = state.StateName;
                    countryStateLstDTO.LstState.Add(stateDTO);
                }
                countryStateLstDTOs.Add(countryStateLstDTO);
            }
            return Ok(countryStateLstDTOs);
        }
    }
}
