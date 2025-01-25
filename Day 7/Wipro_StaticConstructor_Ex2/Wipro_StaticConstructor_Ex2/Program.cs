using System;

namespace Wipro_StaticConstructor_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Company Address 1============");
            Company.companyId = 1001;
            Company.companyName = "Wipro";
            Company.companyAddress = "Bangalore";
            Console.WriteLine($"Company ID: {Company.companyId}|   Company Name: {Company.companyName}|   " +
                $"Company Address: {Company.companyAddress}|");

            Console.WriteLine("============Company Address 2============");
            Company.companyId = 1001;
            Company.companyName = "Wipro";
            Company.companyAddress = "Kolkata";
            Console.WriteLine($"Company ID: {Company.companyId}|   Company Name: {Company.companyName}|   " +
                $"Company Address: {Company.companyAddress}|");

            Console.WriteLine("============Company Address 3============");
            Company.companyId = 1001;
            Company.companyName = "Wipro";
            Company.companyAddress = "Chennai";
            Console.WriteLine($"Company ID: {Company.companyId}|   Company Name: {Company.companyName}|   " +
                $"Company Address: {Company.companyAddress}|");

            Console.ReadLine();
        }
    }
}
