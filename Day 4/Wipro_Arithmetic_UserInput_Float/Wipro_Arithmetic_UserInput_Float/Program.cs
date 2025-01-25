using System;

namespace Wipro_Arithmetic_UserInput_Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the first number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float num2 = float.Parse(Console.ReadLine());

            float result = num1 + num2;
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
