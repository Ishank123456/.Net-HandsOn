using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployee(int empId);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        bool DeleteEmployee(int empId);
    }
}
