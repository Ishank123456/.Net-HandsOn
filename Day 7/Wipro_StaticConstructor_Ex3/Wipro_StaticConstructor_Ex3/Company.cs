using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StaticConstructor_Ex3
{
    public class Company
    {
        public int companyId;
        public string companyName;
        public string companyAddress;

        public Company()
        {
            Console.WriteLine("Default Constructor Called");
        }
        static Company()
        {
            Console.WriteLine("Static Constructor Called");
        }
    }
}
