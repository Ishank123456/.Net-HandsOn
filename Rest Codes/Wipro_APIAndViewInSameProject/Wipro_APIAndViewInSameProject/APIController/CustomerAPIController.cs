using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_APIAndViewInSameProject.Models;
using Wipro_APIAndViewInSameProject.Repository;

namespace Wipro_APIAndViewInSameProject.APIController
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerAPIController : ControllerBase
	{
		private readonly ICustomerRepository iCustomerRepository;
		public CustomerAPIController(ICustomerRepository _iCustomerRepository)
		{
			iCustomerRepository = _iCustomerRepository;
		}

		[HttpPost("Create")]
		public ActionResult CreateCustomer(Customer customer)
		{
			return Ok(iCustomerRepository.CreateCustomer(customer));
		}

		[HttpGet("CustomerList")]
		public ActionResult GetCustomerList()
		{
			return Ok(iCustomerRepository.GetAllCustomers());
		}

		[HttpGet("SearchCustomerById")]
		public ActionResult SearchCustomerById(int id)
		{
			return Ok(iCustomerRepository.GetCustomer(id));
		}

		[HttpPut("Update")]
		public ActionResult UpdateCustomer(Customer customer)
		{
			return Ok(iCustomerRepository.UpdateCustomer(customer));
		}

		[HttpPost("Delete")]
		public ActionResult DeleteCustomer(Customer customer)
		{
			return Ok(iCustomerRepository.DeleteCustomer(customer));
		}
	}
}
