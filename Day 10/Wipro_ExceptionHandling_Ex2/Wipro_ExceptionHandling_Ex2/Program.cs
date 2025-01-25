using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ExceptionHandling_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 25, 31, 67, 98 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"The Value would be: {arr[i]}");
                    Console.WriteLine($"The Value would be: {arr[i] / arr[i + 1]}");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"The Error is: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The Error is: {e.Message}");
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"The value would be: {arr[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
