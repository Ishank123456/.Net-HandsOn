using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Assignment_ForLoop_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the number:");
            int num  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the testing Condition:");
            int testNum = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i <= testNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                }
            }
            Console.ReadLine();
            goto start;
        }
    }
}
