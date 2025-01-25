using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_WhileLoop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("========One to Ten========");
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("========Zero to Nine========");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("========Ten to Zero========");
            int k = 10;
            while (k >= 0)
            {
                Console.WriteLine(k);
                k--;
            }
            Console.ReadLine();
        }
    }
}
