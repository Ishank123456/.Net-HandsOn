using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_DesignPattern_Ex_2
{
    public sealed class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float EmpSal {  get; set; }

        private static Employee employee;

        private Employee()
        {

        }

        //A public method to access outside of the class to create an object  
        public static Employee CreateObject()
        {
            if (employee == null)
            {
                employee = new Employee();
            }
            return employee;
        }
    }
}
