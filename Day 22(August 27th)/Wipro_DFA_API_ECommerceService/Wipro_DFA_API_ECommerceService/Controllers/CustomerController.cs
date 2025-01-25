using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_DFA_API_ECommerceService.Models;
using Wipro_DFA_API_ECommerceService.Repository;

namespace Wipro_DFA_API_ECommerceService.Controllers
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
        public ActionResult SearchCustomer(int custId)
        {
            return Ok(iCustomerRepository.SearchCustomer(custId));
        }

        [HttpPut("UpdateCustomer")]
        public ActionResult UpdateCustomer(Customer customer)
        {
            return Ok(iCustomerRepository.UpdateCustomer(customer));
        }

        [HttpDelete("DeleteCustomer")]
        public ActionResult DeleteCustomer(int custId)
        {
            return Ok(iCustomerRepository.DeleteCustomer(custId));
        }
    }
}
