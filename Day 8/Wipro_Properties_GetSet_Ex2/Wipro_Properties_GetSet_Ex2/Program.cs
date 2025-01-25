using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Properties_GetSet_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================Customer One==========================");
            Customer objCustomer = new Customer()
            {
                CustomerId = 101,
                CustomerName = "Rahul",
                CustomerGender = "Male",
                CustomerAddress = "India",
                CustomerEmail = "rahul021@gmail.com",
                CustomerContact = "+91-8793472809"
            };
            Console.WriteLine($"Customer ID: {objCustomer.CustomerId}|   Customer Name: {objCustomer.CustomerName}|" + "   " +
                              $"Customer Gender: {objCustomer.CustomerGender}|   Customer Address: {objCustomer.CustomerAddress}" + "   " +
                              $"Customer Email: {objCustomer.CustomerEmail}|   Customer Contact: {objCustomer.CustomerContact}");

            Console.WriteLine("==========================Customer Two==========================");
            Customer objCustomer1 = new Customer()
            {
                CustomerId = 102,
                CustomerName = "Emma",
                CustomerGender = "Female",
                CustomerAddress = "USA",
                CustomerEmail = "emma876@gmail.com",
                CustomerContact = "+1-0956743831"
            };
            Console.WriteLine($"Customer ID: {objCustomer1.CustomerId}|   Customer Name: {objCustomer1.CustomerName}|" + "   " +
                              $"Customer Gender: {objCustomer1.CustomerGender}|   Customer Address: {objCustomer1.CustomerAddress}" + "   " +
                              $"Customer Email: {objCustomer1.CustomerEmail}|   Customer Contact: {objCustomer1.CustomerContact}");

            Console.ReadLine();
        }
    }
}
