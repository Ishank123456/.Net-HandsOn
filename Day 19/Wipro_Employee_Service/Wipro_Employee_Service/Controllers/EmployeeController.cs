using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_Employee_Service.Models;

namespace Wipro_Employee_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employeeList = new List<Employee>();

        public EmployeeController()
        {
            Employee objEmp1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Rahul",
                EmpAge = 23,
                EmpSal = 60000,
                EmpCountry = "India"
            };
            employeeList.Add(objEmp1);

            Employee objEmp2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Subham",
                EmpAge = 24,
                EmpSal = 70000,
                EmpCountry = "India"
            };
            employeeList.Add(objEmp2);

            Employee objEmp3 = new Employee()
            {
                EmpId = 103,
                EmpName = "Davis",
                EmpAge = 22,
                EmpSal = 90000,
                EmpCountry = "USA"
            };
            employeeList.Add(objEmp3);

            Employee objEmp4 = new Employee()
            {
                EmpId = 104,
                EmpName = "Priya",
                EmpAge = 21,
                EmpSal = 65000,
                EmpCountry = "India"
            };
            employeeList.Add(objEmp4);
        }

        [HttpGet("FetchEmployee")]
        public List<Employee> FetchEmployee()
        {
            return employeeList;
        }

        [HttpGet("FetchEmployeeById")]
        public Employee FetchById(int id)
        {
            return employeeList.Find(x => x.EmpId == id);
        }
    }
}
