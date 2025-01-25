using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SealedClass_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer objCustomer = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Rahul",
                CustomerAddress = "India"
            };
            Console.WriteLine($"Employee ID: {objCustomer.CustomerId}   |   Employee Name: {objCustomer.CustomerName}   |   " +
                              $"Employee Salary: {objCustomer.CustomerAddress}");

            C1 objC1 = new C1()
            {
                CustomerId = 102,
                CustomerName = "David",
                CustomerAddress = 500000f
            };
            Console.WriteLine($"Employee ID: {objC1.CustomerId}   |   Employee Name: {objC1.CustomerName}   |   " +
                              $"Employee Salary: {objC1.CustomerAddress}");

            Console.ReadLine();
        }
    }
}
