using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Properties_Ex1
{
    public class Employee
    {
        private int _empId;
        private string _empName;
        private string _empAddress;
        private double _empSalary;

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        public string EmpAddress
        {
            get { return _empAddress; }
            set { _empAddress = value; }
        }
        public double EmpSalary
        {
            get { return _empSalary; }
            set { _empSalary = value; }
        }
    }
}
