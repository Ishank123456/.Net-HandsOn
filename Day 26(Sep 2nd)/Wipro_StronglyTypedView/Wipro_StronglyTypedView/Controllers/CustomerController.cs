using Microsoft.AspNetCore.Mvc;
using Wipro_StronglyTypedView.Models;

namespace Wipro_StronglyTypedView.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> lstCustomer = new List<Customer>()
            {
                new Customer()
                {
                    CustId = 101, CustName = "Subham", CustAddress = "Kolkata", CustContactNo = "9856231458"
                },
                new Customer()
                {
                    CustId = 102, CustName = "Pooja", CustAddress = "Delhi", CustContactNo = "8745962315"
                },
                new Customer()
                {
                    CustId = 103, CustName = "Vinay", CustAddress = "Mumbai", CustContactNo = "7895463215"
                }
            };

            return View(lstCustomer);
        }
    }
}
