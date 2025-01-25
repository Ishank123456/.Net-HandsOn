using System;

namespace Wipro_DIPrinciple_Ex2
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public Department(int _deptId, string _deptName)
        {
            DeptId = _deptId;
            DeptName = _deptName;

            Console.WriteLine("==============================Department Details==============================");
            Console.WriteLine($"Department ID: {DeptId}   |   Department Name: {DeptName}");
        }
    }
}
