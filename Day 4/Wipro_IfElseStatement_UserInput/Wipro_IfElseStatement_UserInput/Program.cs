using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_IfElseStatement_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.ReadLine();
            goto start;
        }
    }
}
