using Microsoft.AspNetCore.Mvc;
using Wipro_ViewData_Ex3.Models;

namespace Wipro_ViewData_Ex3.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDetails()
        {
            List<Customer> lstCustomers = new List<Customer>();

            Customer objCustomer1 = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Rahul",
                CustomerAddress = "Maharashtra, India",
                CustomerCity = "Mumbai"
            };
            lstCustomers.Add(objCustomer1);

            Customer objCustomer2 = new Customer()
            {
                CustomerId = 102,
                CustomerName = "Priya",
                CustomerAddress = "Delhi, India",
                CustomerCity = "New Delhi"
            };
            lstCustomers.Add(objCustomer2);

            Customer objCustomer3 = new Customer()
            {
                CustomerId = 103,
                CustomerName = "Subham",
                CustomerAddress = "W.B., India",
                CustomerCity = "Kolkata"
            };
            lstCustomers.Add(objCustomer3);

            Customer objCustomer4 = new Customer()
            {
                CustomerId = 104,
                CustomerName = "David",
                CustomerAddress = "California, USA",
                CustomerCity = "Los Angeles"
            };
            lstCustomers.Add(objCustomer4);

            Customer objCustomer5 = new Customer()
            {
                CustomerId = 105,
                CustomerName = "Emma",
                CustomerAddress = "London, UK",
                CustomerCity = "London"
            };
            lstCustomers.Add(objCustomer5);

            ViewData["LstCustomer"] = lstCustomers;
            return View();
        }
    }
}
