using Microsoft.AspNetCore.Mvc;
using Wipro_ViewData.Models;

namespace Wipro_ViewData.Controllers
{
    public class EmployeeController : Controller
    {
        Employee objEmployee = new Employee()
        {
            EmpId = 101,
            EmpName = "Subham",
            EmpSal = 50000
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeDetails()
        {
            string empId = $"Employee ID: {objEmployee.EmpId}";
            string empName = $"Employee Name: {objEmployee.EmpName}";
            string empSal = $"Employee Salary: {objEmployee.EmpSal}";
            ViewData["EmployeeID"] = empId;
            ViewData["EmployeeName"] = empName;
            ViewData["EmployeeSalary"] = empSal;
            return View();

        }
    }
}
