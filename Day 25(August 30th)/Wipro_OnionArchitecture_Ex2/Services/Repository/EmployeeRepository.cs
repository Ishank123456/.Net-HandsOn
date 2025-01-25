using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EmployeeRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public Employee CreateEmployee(Employee employee)
        {
            var result = applicationDbContext.Employees.Add(employee);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteEmployee(int empId)
        {
            var filterData = applicationDbContext.Employees.SingleOrDefault(e => e.EmpId == empId);
            var result = applicationDbContext.Employees.Remove(filterData);
            applicationDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return applicationDbContext.Employees.ToList();
        }

        public Employee GetEmployee(int empId)
        {
            return applicationDbContext.Employees.SingleOrDefault(e => e.EmpId == empId);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var result = applicationDbContext.Employees.Update(employee);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
