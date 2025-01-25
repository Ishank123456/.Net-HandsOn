using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Array_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 23, 45, 43, 6, 76 };
            Console.WriteLine($"The element in the first index is {arr[0]}");

            arr[0] = 94;
            Console.WriteLine($"New value at index 0: {arr[0]}");

            arr[1] = 54;
            Console.WriteLine($"New value at index 1: {arr[1]}");

            Console.ReadLine();
        }
    }
}
