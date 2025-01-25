using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticConstructor_Ex1
{
    public class Company
    {
        public static int companyId;
        public static string companyName;
        public static string companyAddress;

        static Company()
        {
            Console.WriteLine("Static Constructor Called");
        }
    }
}
