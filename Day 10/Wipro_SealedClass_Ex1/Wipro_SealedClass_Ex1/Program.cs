using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SealedClass_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 101,
                EmpName = "Rahul",
                EmpSal = 600000f
            };
            Console.WriteLine($"Employee ID: {objEmployee.EmpId}   |   Employee Name: {objEmployee.EmpName}   |   " +
                              $"Employee Salary: {objEmployee.EmpSal}");

            EmployeeDetails objEmployeeDetails = new EmployeeDetails()
            {
                EmpId = 102,
                EmpName = "David",
                EmpSal = 500000f
            };
            Console.WriteLine($"Employee ID: {objEmployeeDetails.EmpId}   |   Employee Name: {objEmployeeDetails.EmpName}   |   " +
                              $"Employee Salary: {objEmployeeDetails.EmpSal}");

            Console.ReadLine();
        }
    }
}
