using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_RelationalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine($"Value of a: {a}");
            Console.WriteLine($"Value of b: {b}");

            bool result;
            result = a > b;
            Console.WriteLine($"a is greater than b: {result}");

            result = a < b;
            Console.WriteLine($"a is less than b: {result}");

            result = a >= b;
            Console.WriteLine($"a is greater than or equal to b: {result}");

            result = a <= b;
            Console.WriteLine($"a is less than or equal to b: {result}");

            int a1 = 10;
            int b1 = 10;
            Console.WriteLine($"Value of a1: {a1}");
            Console.WriteLine($"Value of b1: {b1}");

            result = a1 >= b1;
            Console.WriteLine($"a1 is greater than or equal to b1: {result}");

            result = a1 <= b1;
            Console.WriteLine($"a1 is less than or equal to b1: {result}");

            Console.ReadLine();
        }
    }
}
