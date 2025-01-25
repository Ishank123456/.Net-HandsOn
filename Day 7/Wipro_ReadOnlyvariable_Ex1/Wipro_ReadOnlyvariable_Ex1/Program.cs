using System;

namespace Wipro_ReadOnlyvariable_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================Employee Details==================");

            Wipro objSubham1 = new Wipro();
            objSubham1.empDesignation = "Project Engineer";
            objSubham1.empSalary = 350000;
            Console.WriteLine($"Employee ID: {objSubham1.empId}|   Employee Name: {objSubham1.empName}" + "   " +
                                $"Employee Designation: {objSubham1.empDesignation}|   Employee Salary: {objSubham1.empSalary}");

            Wipro objSubham2 = new Wipro();
            objSubham2.empDesignation = "Software Engineer";
            objSubham2.empSalary = 600000;
            Console.WriteLine($"Employee ID: {objSubham2.empId}|   Employee Name: {objSubham2.empName}" + "   " +
                                $"Employee Designation: {objSubham2.empDesignation}|   Employee Salary: {objSubham2.empSalary}");

            Wipro objSubham3 = new Wipro();
            objSubham3.empDesignation = "Lead SDE-I";
            objSubham3.empSalary = 900000;
            Console.WriteLine($"Employee ID: {objSubham3.empId}|   Employee Name: {objSubham3.empName}" + "   " +
                                $"Employee Designation: {objSubham3.empDesignation}|   Employee Salary: {objSubham3.empSalary}");

            Console.ReadLine();
        }
    }
}
