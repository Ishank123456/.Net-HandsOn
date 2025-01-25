using System;

namespace Wipro_StaticConstructor_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Static Constructor============");
            Company.companyId = 1001;
            Company.companyName = "Wipro";
            Company.companyAddress = "Bangalore";
            Console.WriteLine($"Company ID: {Company.companyId}|   Company Name: {Company.companyName}|   " +
                $"Company Address: {Company.companyAddress}|");

            Console.ReadLine();
        }
    }
}
