using System;

namespace Wipro_ForAndForEachLoop_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 's', 'A', 'g', 'y', 'R' };

            Console.WriteLine("============Using For loop============");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("============Using ForEach loop============");
            foreach (char c in arr)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
