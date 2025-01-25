using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wipro_First_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("FetchCustomer")]
        public IActionResult FetchAllWiproCandidates()
        {
            return Ok("All Wipro Candidates Learning .Net Core Web Api");
        }

        [HttpGet("FetchCustomerWipro")]
        public IActionResult FetchAllWipro()
        {
            return Ok("Candidates Learning .Net Core Web Api");
        }
    }
}
