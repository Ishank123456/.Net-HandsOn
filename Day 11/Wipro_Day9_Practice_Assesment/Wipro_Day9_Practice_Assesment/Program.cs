using System;
using System.Collections.Generic;

namespace Wipro_Day9_Practice_Assesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployees = new List<Employee>();

            start:
            Employee objEmployee = new Employee();
            Console.WriteLine("Enter Employee ID: ");
            objEmployee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            objEmployee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address: ");
            objEmployee.EmpAddress = Console.ReadLine();
            Console.WriteLine("Enter Employee Contact: ");
            objEmployee.EmpContact = Console.ReadLine();
            Console.WriteLine("Enter Employee Email: ");
            objEmployee.EmpEmail = Console.ReadLine();
            Console.WriteLine();


            List<Department> lstDepts = new List<Department>();
            Console.WriteLine("Enter the number of Departments the Employee Works: ");
            int numDept = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numDept; i++)
            {
                Department objDept = new Department();
                Console.WriteLine($"Enter Department {i} Name: ");
                objDept.DeptName = Console.ReadLine();
                lstDepts.Add(objDept);
            }


            objEmployee.lstDept = lstDepts;
            lstEmployees.Add(objEmployee);

            Console.WriteLine("==============================================Employee Details==============================================");
            Console.WriteLine();
            foreach (var employee in lstEmployees)
            {
                Console.WriteLine($"================================Employee {employee.EmpName} Details================================");
                Console.WriteLine($"Employee ID: {employee.EmpId}   |   Employee Name: {employee.EmpName}");
                Console.WriteLine($"Employee Address: {employee.EmpAddress}   |   Employee Contact: {employee.EmpContact}");
                Console.WriteLine($"Employee Email: {employee.EmpEmail}");

                Console.WriteLine();
                Console.WriteLine("Department Details: ");
                foreach (var dept in employee.lstDept)
                {
                    Console.WriteLine(dept.DeptName);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            goto start;
        }
    }
}
