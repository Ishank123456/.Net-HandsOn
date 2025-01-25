using Wipro_API_EmployeeService_Ex2.Model;

namespace Wipro_API_EmployeeService_Ex2.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee SearchEmployee(int id);

        int CreateEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(Employee employee);
    }
}
