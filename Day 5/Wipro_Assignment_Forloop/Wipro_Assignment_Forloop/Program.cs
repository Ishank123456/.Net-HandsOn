using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Assignment_Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============Using For Loop=============");
            for (int i = 1; i <= 50; i++)
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

            Console.WriteLine("=============Using While Loop=============");
            int j = 1;
            while (j <= 50)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine($"{j} is an even number");
                }
                else
                {
                    Console.WriteLine($"{j} is an odd number");
                }
                j++;
            }
            Console.ReadLine();
        }
    }
}
