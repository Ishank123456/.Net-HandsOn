using System;

namespace Wipro_DIPrinciple_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee(101, "Subham", 700000f, "Software Engg.", new Department(1, "IT"));

            Console.ReadLine();
        }
    }
}
