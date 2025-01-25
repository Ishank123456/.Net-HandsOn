using System;

namespace Wipro_UnaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, res;
            res = x++;
            Console.WriteLine($"The value of x would be: {x}");
            Console.WriteLine($"The value of res would be: {res}");

            int x1 = 10, res1;
            res1 = x1--;
            Console.WriteLine($"The value of x1 would be: {x1}");
            Console.WriteLine($"The value of res1 would be: {res1}");

            int x2 = 10, res2;
            res2 = ++x2;
            Console.WriteLine($"The value of x2 would be: {x2}");
            Console.WriteLine($"The value of res2 would be: {res2}");

            int x3 = 10, res3;
            res3 = --x3;
            Console.WriteLine($"The value of x3 would be: {x3}");
            Console.WriteLine($"The value of res3 would be: {res3}");

            Console.ReadLine();
        }
    }
}
