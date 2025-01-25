using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_NestedForloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Nested For Loop============");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"{i} {j}");
                }
            }

            Console.WriteLine("============Nested For Loop Backward Direction============");
            for (int i = 3; i >= 1; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    Console.WriteLine($"{i} {j}");
                }
            }
            Console.ReadLine();
        }
    }
}
