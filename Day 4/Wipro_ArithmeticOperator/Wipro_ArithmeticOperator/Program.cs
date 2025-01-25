using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ArithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 40;

            int result = a + b;
            Console.WriteLine($"The Addition of a and b is: {result}");

            result = a - b;
            Console.WriteLine($"The Substraction of a and b is: {result}");

            result = a * b;
            Console.WriteLine($"The Multiplication of a and b is: {result}");

            result = (a / b);
            Console.WriteLine($"The Division of a and b is: {result}");

            Console.ReadLine();
        }
    }
}
