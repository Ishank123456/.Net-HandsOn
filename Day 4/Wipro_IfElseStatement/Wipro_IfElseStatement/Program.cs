using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 30;
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
        }
    }
}
