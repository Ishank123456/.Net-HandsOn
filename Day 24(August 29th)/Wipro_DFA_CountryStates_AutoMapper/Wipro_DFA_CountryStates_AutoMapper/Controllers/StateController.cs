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
    public class StateController : ControllerBase
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;
        public StateController(IStateRepository _stateRepository, IMapper _mapper)
        {
            stateRepository = _stateRepository;
            mapper = _mapper;
        }

        [HttpPost("CreateState")]
        public ActionResult CreateState(CreateStateDTO stateDTO)
        {
            stateRepository.InsertState(mapper.Map<State>(stateDTO));
            return Ok();
        }

        [HttpGet("GetAllStates")]
        public ActionResult GetAllStates()
        {
            return Ok(stateRepository.GetStates().ToList());
        }

        [HttpGet("SearchStateById")]
        public ActionResult SearchState(int searchId)
        {
            return Ok(stateRepository.GetState(searchId));
        }

        [HttpPut("UpdateState")]
        public ActionResult UpdateState(UpdateStateDTO stateDTO)
        {
            stateRepository.UpdateState(mapper.Map<State>(stateDTO));
            return Ok();
        }

        [HttpDelete("DeleteState")]
        public ActionResult DeleteState(int stateId)
        {
            stateRepository.DeleteState(stateId);
            return Ok();
        }
    }
}
