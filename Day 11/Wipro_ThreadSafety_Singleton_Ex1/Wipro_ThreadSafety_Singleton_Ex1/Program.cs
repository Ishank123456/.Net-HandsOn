using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ThreadSafety_Singleton_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee1 = Employee.GetEmployee;
            objEmployee1.EmpId = 101;
            objEmployee1.EmpName = "Subham";
            objEmployee1.EmpSal = 500000d;
            Console.WriteLine($"Employee ID: {objEmployee1.EmpId}   |   Employee Name: {objEmployee1.EmpName}   |   " +
                              $"Employee Salary: {objEmployee1.EmpSal}");

            Employee objEmployee2 = Employee.GetEmployee;
            objEmployee2.EmpId = 102;
            objEmployee2.EmpName = "Rahul";
            objEmployee2.EmpSal = 600000d;
            Console.WriteLine($"Employee ID: {objEmployee2.EmpId}   |   Employee Name: {objEmployee2.EmpName}   |   " +
                              $"Employee Salary: {objEmployee2.EmpSal}");

            Employee objEmployee3 = Employee.GetEmployee;
            objEmployee3.EmpId = 103;
            objEmployee3.EmpName = "Somnath";
            objEmployee3.EmpSal = 700000d;
            Console.WriteLine($"Employee ID: {objEmployee3.EmpId}   |   Employee Name: {objEmployee3.EmpName}   |   " +
                              $"Employee Salary: {objEmployee3.EmpSal}");

            Console.ReadLine();
        }
    }
}
