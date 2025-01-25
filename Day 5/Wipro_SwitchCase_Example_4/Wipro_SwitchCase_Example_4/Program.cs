using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_SwitchCase_Example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter opeartor:");
            double op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    double result = num1 + num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine($"The result is: {result}");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
