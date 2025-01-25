using System;
namespace Wipro_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Value of str: {Constants.str}");
            Console.WriteLine($"Value of pi: {Constants.pi}");

            Console.ReadLine();
        }
    }
    public class Constants
    {
        public const string str = "Wipro";
        public const float pi = 3.14f;
    }
}
