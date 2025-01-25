using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ClassesAndObjects_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee1 = new Employee();
            objEmployee1.empId = 101;
            objEmployee1.empName = "Rahul";
            objEmployee1.empContact = "+91-7865094781";
            objEmployee1.empSal = 400000d;

            Console.WriteLine($"Employee Id: {objEmployee1.empId}| Employee Name: {objEmployee1.empName}|" + " " +
                              $"Employee Contact: {objEmployee1.empContact}| Employee Salary: {objEmployee1.empSal}");

            Employee objEmployee2 = new Employee();
            objEmployee2.empId = 102;
            objEmployee2.empName = "Subham";
            objEmployee2.empContact = "+91-7384741470";
            objEmployee2.empSal = 600000d;

            Console.WriteLine($"Employee Id: {objEmployee2.empId}| Employee Name: {objEmployee2.empName}|" + " " +
                              $"Employee Contact: {objEmployee2.empContact}| Employee Salary: {objEmployee2.empSal}");

            Employee objEmployee3 = new Employee();
            objEmployee3.empId = 103;
            objEmployee3.empName = "David";
            objEmployee3.empContact = "+1-60789778";
            objEmployee3.empSal = 500000d;

            Console.WriteLine($"Employee Id: {objEmployee3.empId}| Employee Name: {objEmployee3.empName}|" + " " +
                              $"Employee Contact: {objEmployee3.empContact}| Employee Salary: {objEmployee3.empSal}");

            Employee objEmployee4 = new Employee();
            objEmployee4.empId = 104;
            objEmployee4.empName = "Xian Ji";
            objEmployee4.empContact = "+86-679085423";
            objEmployee4.empSal = 700000d;

            Console.WriteLine($"Employee Id: {objEmployee4.empId}| Employee Name: {objEmployee4.empName}|" + " " +
                              $"Employee Contact: {objEmployee4.empContact}| Employee Salary: {objEmployee4.empSal}");

            Employee objEmployee5 = new Employee();
            objEmployee5.empId = 105;
            objEmployee5.empName = "Karen";
            objEmployee5.empContact = "+91-980653456";
            objEmployee5.empSal = 450000d;

            Console.WriteLine($"Employee Id: {objEmployee5.empId}| Employee Name: {objEmployee5.empName}|" + " " +
                              $"Employee Contact: {objEmployee5.empContact}| Employee Salary: {objEmployee5.empSal}");

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int empId;
        public string empName;
        public string empContact;
        public double empSal;
    }
}
