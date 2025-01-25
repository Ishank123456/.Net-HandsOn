using System.Collections.Generic;

namespace Wipro_ListCollection_Ex4
{
    public class Employee
    {
        public int EmpId {  get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }
        public string EmpDesignation { get; set; }

        public List<Department> lstDept { get; set; }
    }
}
