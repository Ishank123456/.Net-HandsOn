using System;

namespace Wipro_CallByValue_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Call by Value===========");
            int val = 15;
            Console.WriteLine($"The value before passed to the function: {val}");

            Program objprogram = new Program();
            objprogram.Show(val);
            Console.WriteLine($"The value after passed to the function: {val}");

            Console.ReadLine();
        }

        public void Show(int val)
        {
            val *= val;
            Console.WriteLine($"The value inside the function: {val}");
        }
    }
}
