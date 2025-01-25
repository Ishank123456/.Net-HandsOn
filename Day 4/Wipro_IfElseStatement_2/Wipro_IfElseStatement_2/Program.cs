using System;

namespace Wipro_IfElseStatement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("The number to check greater or smaller");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number to which to compare");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            Console.ReadLine();
            goto start;
        }
    }
}
