using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Properties_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 101,
                EmpName = "Subham",
                EmpAddress = "Kolkata",
                EmpSalary = 600000
            };

            Console.WriteLine($"Employee ID: {objEmployee.EmpId}|   Employee Name: {objEmployee.EmpName}|" + "   " + 
                              $"Employee Address: {objEmployee.EmpAddress}|   Employee Salary: {objEmployee.EmpSalary}|");

            Console.ReadLine();
        }
    }
}
