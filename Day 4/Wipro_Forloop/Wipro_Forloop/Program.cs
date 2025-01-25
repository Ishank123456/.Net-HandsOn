using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================For Loop==================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For loop executed {i} times");
            }

            Console.WriteLine("=========================================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"For loop executed {i} times");
            }
            Console.WriteLine("=========================================");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"For loop executed {i}");
            }
            Console.ReadLine();
        }
    }
}
