using System;

namespace Wipro_DIPrinciple_Ex2
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float EmpSal { get; set; }
        public string EmpDesignation { get; set; }

        Department department;
        public Employee(int _empId, string _empName, float _empSal, string _empDesignation, Department _department)
        {
            EmpId = _empId;
            EmpName = _empName;
            EmpSal = _empSal;
            EmpDesignation = _empDesignation;

            department = _department;

            Console.WriteLine("==============================Employee Details==============================");
            Console.WriteLine($"Employee ID: {EmpId}   |   Employee Name: {EmpName}");
            Console.WriteLine($"Employee Salary: {EmpSal}   |   Employee Desigantion: {EmpDesignation}");
        }
    }
}
