using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_EmployeeService_Ex2.Model;
using Wipro_API_EmployeeService_Ex2.Repository;

namespace Wipro_API_EmployeeService_Ex2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository iEmployeeRepository;
        public EmployeeController(IEmployeeRepository _iEmployeeRepository)
        {
            iEmployeeRepository = _iEmployeeRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateEmployee(Employee employee)
        {
            return Ok(iEmployeeRepository.CreateEmployee(employee));
        }

        [HttpGet("GetEmployeeList")]
        public ActionResult GetEmployeeList()
        {
            return Ok(iEmployeeRepository.GetEmployees());
        }

        [HttpGet("SearchById")]
        public ActionResult SearchEmployeeById(int empId)
        {
            return Ok(iEmployeeRepository.SearchEmployee(empId));
        }

        [HttpPost("Update")]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return Ok(iEmployeeRepository.UpdateEmployee(employee));
        }

        [HttpPost("Delete")]
        public ActionResult DeleteEmployee(Employee employee)
        {
            return Ok(iEmployeeRepository.DeleteEmployee(employee));
        }
    }
}
