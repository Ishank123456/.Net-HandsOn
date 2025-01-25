using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_CFA_VehicleService.Model;
using Wipro_API_CFA_VehicleService.Repository;

namespace Wipro_API_CFA_VehicleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository iCustomerRepository;
        public CustomerController(ICustomerRepository _iCustomerRepository)
        {
            iCustomerRepository = _iCustomerRepository;
        }

        [HttpPost("CreateCustomer")]
        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(iCustomerRepository.CreateCustomer(customer));
        }

        [HttpGet("GetAllCustomers")]
        public ActionResult GetAllCustomers()
        {
            return Ok(iCustomerRepository.GetAllCustomers());
        }

        [HttpGet("SearchCustomerById")]
        public ActionResult SearchCustomerById(int custId)
        {
            return Ok(iCustomerRepository.SearchCustomer(custId));
        }

        [HttpPut("UpdateCustomerInfo")]
        public ActionResult UpdateCustomerInfo(Customer customer)
        {
            return Ok(iCustomerRepository.UpdateCustomerInfo(customer));
        }

        [HttpDelete("DeleteCustomerInfo")]
        public ActionResult DeleteCustomerInfo(int custId)
        {
            return Ok(iCustomerRepository.DeleteCustomerInfo(custId));
        }
    }
}
