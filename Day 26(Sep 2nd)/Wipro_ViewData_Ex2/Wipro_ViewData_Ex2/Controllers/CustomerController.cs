using Microsoft.AspNetCore.Mvc;
using Wipro_ViewData_Ex2.Models;

namespace Wipro_ViewData_Ex2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDetails()
        {
            ViewData["Title"] = "Customer Details Page";
            ViewData["Header"] = "Customer Page";

            Customer objCustomer = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Rahul",
                CustomerAddress = "Mumbai",
                CustomerEmail = "rahul@gmail.com",
                CustomerContact = "8956231459",
                CustomerAge = 26,
                CustomerGender = "Male"
            };

            ViewData["CustomerDetails"] = objCustomer;
            return View();
        }
    }
}
