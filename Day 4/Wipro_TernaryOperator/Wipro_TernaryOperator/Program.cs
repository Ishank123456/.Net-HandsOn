using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int result;

            result = x < y ? x : y;
            Console.WriteLine($"The result would be: {result}");

            result = x > y ? x : y;
            Console.WriteLine($"The result would be: {result}");

            Console.ReadLine();
        }
    }
}
