using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ListCollections_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployee = new List<Employee>();

            Employee objEmployee1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Rahul",
                EmpSal = 500000f
            };
            lstEmployee.Add(objEmployee1);

            Employee objEmployee2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Subham",
                EmpSal = 600000f
            };
            lstEmployee.Add(objEmployee2);

            Employee objEmployee3 = new Employee()
            {
                EmpId = 101,
                EmpName = "Somnath",
                EmpSal = 700000f
            };
            lstEmployee.Add(objEmployee3);

            foreach (Employee objEmployee in lstEmployee)
            {
                Console.WriteLine($"Employee ID: {objEmployee.EmpId}| Employee Name: {objEmployee.EmpName}|" +  "   " +
                                  $"Employee Salary: {objEmployee.EmpSal}");
            }
            Console.ReadLine();
        }
    }
}
