using System;

namespace Wipro_ParameterizedConstructor_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee1 = new Employee();
            objEmployee1.empId = 101;
            objEmployee1.empName = "Emma";
            objEmployee1.empAddress = "London";
            objEmployee1.empGender = "Female";
            Console.WriteLine("==================Employee One==================");
            Console.WriteLine($"ID: {objEmployee1.empId}|   Name: {objEmployee1.empName}|" + "   " +
                              $"Address: {objEmployee1.empAddress}|   Gender: {objEmployee1.empGender}|");

            Employee objEmployee2 = new Employee(102, "Subham", "India", "Male");
            Console.WriteLine("==================Employee Two==================");
            Console.WriteLine($"ID: {objEmployee2.empId}|   Name: {objEmployee2.empName}|" + "   " +
                              $"Address: {objEmployee2.empAddress}|   Gender: {objEmployee2.empGender}|");
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
        
        public int empId;
        public string empName;
        public string empAddress;
        public string empGender;

        public Employee(int _empId, string _empName, string _empAddress, string _empGender)
        {
            Console.WriteLine("Parameterized Constructor Invoked");
            empId = _empId;
            empName = _empName;
            empAddress = _empAddress;
            empGender = _empGender;
        }
    }
}
