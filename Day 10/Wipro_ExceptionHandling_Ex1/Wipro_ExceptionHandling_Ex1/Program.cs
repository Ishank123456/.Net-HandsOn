using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ExceptionHandling_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The Value would be: {arr[i]}");
            }
            try
            {
                Console.WriteLine(arr[6]);
            }
            //use Exception Keyword incase you don't know the exception
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"An Error has occured: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
