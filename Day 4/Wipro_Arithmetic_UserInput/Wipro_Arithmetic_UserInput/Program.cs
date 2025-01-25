using System;

namespace Wipro_Arithmetic_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"The Addition would be: {result}");

            result = num1 - num2;
            Console.WriteLine($"The Substraction would be: {result}");

            result = num1 * num2;
            Console.WriteLine($"The Multiplication would be: {result}");

            result = num1 / num2;
            Console.WriteLine($"The Division would be: {result}");

            Console.ReadLine();
            goto start;
        }
    }
}
