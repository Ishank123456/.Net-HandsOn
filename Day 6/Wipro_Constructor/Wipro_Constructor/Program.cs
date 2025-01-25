using System;

namespace Wipro_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee1 = new Employee();
            Employee objEmployee2 = new Employee();
            Employee objEmployee3 = new Employee();
            Employee objEmployee4 = new Employee();
            Employee objEmployee5 = new Employee();

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
        }

    }
}
