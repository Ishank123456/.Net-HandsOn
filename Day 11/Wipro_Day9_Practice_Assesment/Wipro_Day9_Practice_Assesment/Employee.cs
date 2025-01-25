using System.Collections.Generic;

namespace Wipro_Day9_Practice_Assesment
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpContact { get; set; }
        public string EmpEmail { get; set; }

        public List<Department> lstDept { get; set; }
    }
}
