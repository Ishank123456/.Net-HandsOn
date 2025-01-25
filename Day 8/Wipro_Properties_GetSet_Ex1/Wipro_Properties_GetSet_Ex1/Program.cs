using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Properties_GetSet_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Employee One================");
            Employee objEmployee1 = new Employee()
            {
                EmpId = 101,
                EmpName = "David",
                EmpAddress = "USA",
                EmpSalary = 600000f
            };
            Console.WriteLine($"Employee ID: {objEmployee1.EmpId}|   Employee Name: {objEmployee1.EmpName}|" + "   " +
                                $"Employee Address: {objEmployee1.EmpAddress}|   Employee Salary: {objEmployee1.EmpSalary}");

            Console.WriteLine("================Employee Two================");
            Employee objEmployee2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Subham",
                EmpAddress = "India",
                EmpSalary = 500000f
            };
            Console.WriteLine($"Employee ID: {objEmployee2.EmpId}|   Employee Name: {objEmployee2.EmpName}|" + "   " +
                                $"Employee Address: {objEmployee2.EmpAddress}|   Employee Salary: {objEmployee2.EmpSalary}");

            Console.WriteLine("================Employee Three================");
            Employee objEmployee3 = new Employee()
            {
                EmpId = 103,
                EmpName = "Wang Xi",
                EmpAddress = "China",
                EmpSalary = 700000f
            };
            Console.WriteLine($"Employee ID: {objEmployee3.EmpId}|   Employee Name: {objEmployee3.EmpName}|" + "   " +
                                $"Employee Address: {objEmployee3.EmpAddress}|   Employee Salary: {objEmployee3.EmpSalary}");

            Console.ReadLine();
        }
    }
}
