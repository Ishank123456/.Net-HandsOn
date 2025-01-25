using Microsoft.AspNetCore.Mvc;
using Wipro_StronglyTypedView.Models;

namespace Wipro_StronglyTypedView.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 101,
                EmpName = "Subham",
                EmpSal = 60000
            };

            return View(objEmployee);
        }
    }
}
