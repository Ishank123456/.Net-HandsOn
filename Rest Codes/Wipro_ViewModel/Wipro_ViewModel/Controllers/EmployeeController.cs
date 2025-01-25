using Microsoft.AspNetCore.Mvc;
using Wipro_ViewModel.Models;
using Wipro_ViewModel.ViewModel;

namespace Wipro_ViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 101,
                EmpName = "Subham",
                EmpGender = "Male",
                EmpDept = "IT",
                EmpSal = 60000
            };

            Address objAddress = new Address()
            {
                AddressId = 1,
                Country = "India",
                State = "W.B.",
                City = "Kolkata",
                PinCode = 700007
            };

            EmployeeDetailsViewModel employeeViewModel = new EmployeeDetailsViewModel()
            {
                Employee = objEmployee,
                Address = objAddress,
                PageTitle = "View Model Example Page",
                PageHeader = "Employee Details"
            };


            return View(employeeViewModel);
        }
    }
}
