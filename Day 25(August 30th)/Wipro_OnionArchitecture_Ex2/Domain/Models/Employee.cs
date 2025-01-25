using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal {  get; set; }
        public string EmpCity { get; set; }
        public string EmpGender { get; set; }
        public int DeptId { get; set; }
    }
}
