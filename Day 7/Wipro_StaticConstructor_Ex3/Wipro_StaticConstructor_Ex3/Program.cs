using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticConstructor_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Company Address 1============");
            Company objCompany1 = new Company();
            objCompany1.companyId = 1001;
            objCompany1.companyName = "Wipro";
            objCompany1.companyAddress = "Bangalore";
            Console.WriteLine($"Company ID: {objCompany1.companyId}|   Company Name: {objCompany1.companyName}|   " +
                $"Company Address: {objCompany1.companyAddress}|");

            Console.WriteLine("============Company Address 2============");
            Company objCompany2 = new Company();
            objCompany2.companyId = 1001;
            objCompany2.companyName = "Wipro";
            objCompany2.companyAddress = "Kolkata";
            Console.WriteLine($"Company ID: {objCompany2.companyId}|   Company Name: {objCompany2.companyName}|   " +
                $"Company Address: {objCompany2.companyAddress}|");

            Console.ReadLine();
        }
    }
}
