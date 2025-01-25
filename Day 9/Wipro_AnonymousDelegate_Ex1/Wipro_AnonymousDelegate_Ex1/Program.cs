using System;

namespace Wipro_AnonymousDelegate_Ex1
{
    internal class Program
    {
        public delegate int AddDelegate(int a, int b);
        static void Main(string[] args)
        {
            AddDelegate objAddDelegate = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = objAddDelegate(num1, num2);
            Console.WriteLine($"The Addition would be: {sum}");

            Console.ReadLine();
        }
    }
}
