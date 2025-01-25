using Microsoft.AspNetCore.Mvc;
using Wipro_ViewBag.Models;

namespace Wipro_ViewBag.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerTable()
        {
            List<Customer> lstCustomers = new List<Customer>();

            Customer objCustomer1 = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Subham",
                CustomerAddress = "W.B., India",
                CustomerCity = "Kolkata"
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
                CustomerName = "Rahul",
                CustomerAddress = "Maharashtra., India",
                CustomerCity = "Mumbai"
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

            ViewBag.LstCustomer = lstCustomers;
            return View();
        }
    }
}
