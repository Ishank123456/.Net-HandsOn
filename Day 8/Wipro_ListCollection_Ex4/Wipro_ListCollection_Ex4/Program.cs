using System;
using System.Collections.Generic;

namespace Wipro_ListCollection_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> lstDepts = new List<Department>();

            Department objDepartment1 = new Department()
            {
                DeptId = 1,
                DeptName = "IT"
            };
            Department objDepartment2 = new Department()
            {
                DeptId = 2,
                DeptName = "HR"
            };
            Department objDepartment3 = new Department()
            {
                DeptId = 3,
                DeptName = "Sales"
            };
            lstDepts.Add(objDepartment1);
            lstDepts.Add(objDepartment2);
            lstDepts.Add(objDepartment3);


            List<Employee> lstEmployee = new List<Employee>();

            Employee objEmployee1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Rahul",
                EmpSalary = 500000f,
                EmpDesignation = "Software Engineer"
            };
            objEmployee1.lstDept = lstDepts;

            Employee objEmployee2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Subham",
                EmpSalary = 600000f,
                EmpDesignation = "Team Lead"
            };
            objEmployee2.lstDept = lstDepts;

            Employee objEmployee3 = new Employee()
            {
                EmpId = 103,
                EmpName = "Somnath",
                EmpSalary = 700000f,
                EmpDesignation = "Project Manager"
            };
            objEmployee3.lstDept = lstDepts;

            lstEmployee.Add(objEmployee1);
            lstEmployee.Add(objEmployee2);
            lstEmployee.Add(objEmployee3);

            foreach (var employee in lstEmployee)
            {
                Console.WriteLine($"Employee ID: {employee.EmpId}   |   Employee Name: {employee.EmpName}   |   " +
                                  $"Employee Salary: {employee.EmpSalary}   |   Employee Designation: {employee.EmpDesignation}");

                Console.WriteLine($"{employee.EmpName} would be in the following Departments:: ");
                foreach (var dept in employee.lstDept)
                {
                    Console.WriteLine($"Department ID: {dept.DeptId}   ------->   Department Name: {dept.DeptName}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
