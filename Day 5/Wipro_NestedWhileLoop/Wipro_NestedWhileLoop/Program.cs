using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_NestedWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Nested While Loop==========");
            int i = 1;
            int j = 1;

            while (i <= 3)
            {
                while (j <= 3)
                {
                    Console.WriteLine($"{i} {j}");
                    j++;
                }
                j = 1;
                i++;
            }

            Console.WriteLine("==========Nested While Loop Backward Direction==========");
            int k = 3;
            int l = 3;

            while (k >= 1)
            {
                while (l >= 1)
                {
                    Console.WriteLine($"{k} {l}");
                    l--;
                }
                l = 3;
                k--;
            }
            Console.ReadLine();
        }
    }
}
