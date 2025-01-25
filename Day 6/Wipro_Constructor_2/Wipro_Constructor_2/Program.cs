using System;

namespace Wipro_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer objCustomer1  = new Customer();
            Console.WriteLine("==================Customer One==================");
            objCustomer1.custId = 101;
            objCustomer1.custName = "Subham";
            objCustomer1.custAddress = "Kolkata";
            objCustomer1.custEmail = "sub021@gmail.com";

            Console.WriteLine($"Customer ID: {objCustomer1.custId}|   Customer Name: {objCustomer1.custName}|" + "   " +
                              $"Customer Address: {objCustomer1.custAddress}|   Customer Email: {objCustomer1.custEmail}|");
            Console.WriteLine();


            Customer objCustomer2 = new Customer();
            Console.WriteLine("==================Customer Two==================");
            objCustomer2.custId = 101;
            objCustomer2.custName = "David";
            objCustomer2.custAddress = "London";
            objCustomer2.custEmail = "david876@gmail.com";

            Console.WriteLine($"Customer ID: {objCustomer2.custId}|   Customer Name: {objCustomer2.custName}|" + "   " +
                              $"Customer Address: {objCustomer2.custAddress}|   Customer Email: {objCustomer2.custEmail}|");

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int custId;
        public string custName;
        public string custAddress;
        public string custEmail;
        public Customer()
        {
            //Default Constructor
            Console.WriteLine("Customer Constructor is Invoked");
        }
    }
}
