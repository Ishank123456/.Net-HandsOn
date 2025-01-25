using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ThreadSafety_Singleton_Ex1
{
    public sealed class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSal {  get; set; }

        private Employee()
        {

        }
        private static readonly object padlock = new object();

        private static Employee employee = null;
        public static Employee GetEmployee
        {
            get
            {
                lock (padlock)
                {
                    if (employee == null)
                    {
                        {
                            employee = new Employee();
                        }
                    }
                }
                return employee;
            }
        }
    }
}
