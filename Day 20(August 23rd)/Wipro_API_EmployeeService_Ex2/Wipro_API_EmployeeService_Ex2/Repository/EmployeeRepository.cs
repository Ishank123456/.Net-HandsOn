using Wipro_API_EmployeeService_Ex2.EntityFramework;
using Wipro_API_EmployeeService_Ex2.Model;

namespace Wipro_API_EmployeeService_Ex2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;
        public EmployeeRepository(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }

        public int CreateEmployee(Employee employee)
        {
            employeeDbContext.Employees.Add(employee);
            return employeeDbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employeeDbContext.Employees.ToList();
        }

        public Employee SearchEmployee(int empId)
        {
            return employeeDbContext.Employees.SingleOrDefault(t => t.EmpId == empId);
        }

        public int UpdateEmployee(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            employeeDbContext.Employees.Update(employee);
            return employeeDbContext.SaveChanges();
        }

        public int DeleteEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            employeeDbContext.Employees.Remove(employee);
            return employeeDbContext.SaveChanges();
        }
    }
}
