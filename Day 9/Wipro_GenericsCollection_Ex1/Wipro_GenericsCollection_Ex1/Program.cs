using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericsCollection_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<int> objEmpId = new Employee<int>();
            objEmpId.Value = 1001;

            Employee<string> objEmpName = new Employee<string>();
            objEmpName.Value = "Rahul";

            Employee<decimal> objEmpSal = new Employee<decimal>();
            objEmpSal.Value = 700000.987m;

            Console.WriteLine($"Employee ID: {objEmpId.Value}   |   Employee Name: {objEmpName.Value}   |   " +
                              $"Employee Salary: {objEmpSal.Value}");

            Console.ReadLine();
        }
    }

    public class Employee<T>
    {
        public T Value { get; set; }
    }
}
