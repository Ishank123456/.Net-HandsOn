using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Delegates_Ex1
{
    internal class Program
    {
        public delegate int ArithmeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate objArithmeticDelegate = new ArithmeticDelegate(Add);
            int sum = objArithmeticDelegate.Invoke(20, 10);
            Console.WriteLine($"The Addition would be: {sum}");

            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
