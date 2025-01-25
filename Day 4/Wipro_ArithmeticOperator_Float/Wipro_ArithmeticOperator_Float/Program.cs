using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ArithmeticOperator_Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 10.56f;
            float b = 20.87f;

            float result = a + b;
            Console.WriteLine($"The Addition of a and b is: {result}");

            result = a - b;
            Console.WriteLine($"The Substraction of a and b is: {result}");

            result = a * b;
            Console.WriteLine($"The Multiplication of a and b is: {result}");

            result = a / b;
            Console.WriteLine($"The Division of a and b is: {result}");

            Console.ReadLine();
        }
    }
}
