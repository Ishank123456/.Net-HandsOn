using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticClass_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.companyId = 1002;
            Company.companyName = "Wipro";
            Company.companyAddress = "Kolkata";
            Company.DisplayCompany();

            Console.ReadLine();
        }
    }
}
