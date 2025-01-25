using Microsoft.AspNetCore.Mvc;
using Wipro_ViewModel.Models;
using Wipro_ViewModel.ViewModel;

namespace Wipro_ViewModel.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer objCustomer = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Subham",
                CustomerEmail = "subham@gmail.com",
                CustomerContact = "8956412369",
                CustomerGender = "Male"
            };

            List<AddressCustomer> LstOfCustomerAddress = new List<AddressCustomer>()
            {
                new AddressCustomer()
                {
                    CustomerId = 101,
                    Country = "India",
                    State = "Maharashtra",
                    City = "Mumbai",
                    PinCode = 784562
                },
                new AddressCustomer()
                {
                    CustomerId = 101,
                    Country = "USA",
                    State  ="California",
                    City = "L.A.",
                    PinCode = 90001
                },
                new AddressCustomer()
                {
                    CustomerId = 101,
                    Country = "India",
                    State = "W.B.",
                    City = "Kolkata",
                    PinCode = 700007
                }
            };

            CustomerDetailsViewModel objCustomerDetailsViewModel = new CustomerDetailsViewModel()
            {
                Customer = objCustomer,
                LstCustomerAddress = LstOfCustomerAddress,
            };

            return View(objCustomerDetailsViewModel);
        }
    }
}
