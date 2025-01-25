using System;
using System.Linq;

namespace Wipro_Array_Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 23, 46, 78, 4, 32, 49 };
            Console.WriteLine($"Mininum number of the array: {numArray.Min()}");
            Console.WriteLine($"Maximun number of the array: {numArray.Max()}");
            Console.WriteLine($"Sum of the array: {numArray.Sum()}");
            Console.WriteLine($"Average of the numbers in the array: {numArray.Average()}");
            Console.WriteLine($"No.of elements in the array: {numArray.Count()}");

            Console.ReadLine();
        }
    }
}
