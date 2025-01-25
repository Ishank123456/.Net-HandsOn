using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SealedClass_Ex1
{
    public sealed class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float EmpSal { get; set; }

        public void Display()
        {
            Console.WriteLine("Displaying");
        }
    }

    public class EmployeeDetails : Employee
    {
        public void Display()
        {
            Console.WriteLine("Not Displaying");
        }
    }
}
