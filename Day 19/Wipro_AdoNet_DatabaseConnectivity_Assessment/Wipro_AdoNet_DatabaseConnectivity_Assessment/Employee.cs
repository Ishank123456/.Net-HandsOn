using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AdoNet_DatabaseConnectivity_Assessment
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public decimal EmpSal { get; set; }
        public string EmpCity { get; set; }
        public string EmpEmail { get; set; }
        public string EmpQualification { get; set; }
        public int DeptId { get; set; }
    }
}
