
using System;

namespace Wipro_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 23;
            Object obj = i;

            int j = (int)obj;
            Console.WriteLine($"The value of the obj is: {obj}");
            Console.WriteLine($"The value of the j is: {j}");

            Console.ReadLine();
        }
    }
}
