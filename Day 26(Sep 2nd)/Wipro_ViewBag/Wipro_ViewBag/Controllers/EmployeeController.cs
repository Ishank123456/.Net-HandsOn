using Microsoft.AspNetCore.Mvc;
using Wipro_ViewBag.Models;

namespace Wipro_ViewBag.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 101,
                EmpName = "Subham",
                EmpSal = 60000
            };

            ViewBag.EmpId = objEmployee.EmpId;
            ViewBag.EmpName = objEmployee.EmpName;
            ViewBag.EmpSal = objEmployee.EmpSal;
            return View();
        }
    }
}
