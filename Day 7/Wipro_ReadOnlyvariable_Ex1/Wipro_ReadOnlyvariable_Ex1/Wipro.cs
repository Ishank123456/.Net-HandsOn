using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ReadOnlyvariable_Ex1
{
    public class Wipro
    {
        public readonly int empId;
        public readonly string empName;
        public string empDesignation;
        public double empSalary;

        public Wipro()
        {
            empId = 101;
            empName = "Subham";
        }
    }
}
