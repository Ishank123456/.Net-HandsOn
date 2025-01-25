using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticClass_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.companyId = 1002;
            Company.companyName = "Wipro";
            Company.companyAddress = "Kolkata";

            Console.ReadLine();
        }
    }
    public static class Company
    {
        public static int companyId;
        public static string companyName;
        public static string companyAddress;
    }
}
