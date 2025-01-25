using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnionArchitecture_Ex2.DTO;

namespace Wipro_OnionArchitecture_Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;
        public EmployeeController(IEmployeeRepository _employeeRepository, IMapper _mapper)
        {
            employeeRepository = _employeeRepository;
            mapper = _mapper;
        }

        [HttpPost("CreateEmployee")]
        public IActionResult CreateEmployee(CreateEmpDTO empModel)
        {
            return Ok(employeeRepository.CreateEmployee(mapper.Map<Employee>(empModel)));
        }
    }
}
