using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticClass_Ex2
{
    public static class Company
    {
        public static int companyId;
        public static string companyName;
        public static string companyAddress;

        public static void DisplayCompany()
        {
            Console.WriteLine($"Company ID: {companyId}|   Comapny Name: {companyName}|   Company Address: {companyAddress}|");
        }
    }
}
