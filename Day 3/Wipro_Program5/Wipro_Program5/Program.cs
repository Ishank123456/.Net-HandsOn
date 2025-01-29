using System;

namespace Wipro_Program5
{
    internal class Program ////it shows both boxing and unboxing
    {
        static void Main(string[] args)
        {
            int num = 20;
            object obj = num;
            int raj = (int)obj;

            Console.WriteLine($"The value of the num would be: {num}");
            Console.WriteLine($"The value of the obj would be: {obj}");
            Console.WriteLine($"The value of the obj would be: {raj}");
           
            Console.ReadLine();
        }
    }
}
