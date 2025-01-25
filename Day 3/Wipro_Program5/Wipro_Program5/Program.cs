using System;

namespace Wipro_Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            Object obj = num;
            num = 200;

            Console.WriteLine($"The value of the num would be: {num}");
            Console.WriteLine($"The value of the obj would be: {obj}");
            Console.ReadLine();
        }
    }
}
