using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ActionDelegates_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> myActionAdd = Add;
            myActionAdd(12, 13);
            Action<int, int> myActionSub = Sub;
            myActionSub(80, 56);
            Action<int, int> myActionMul = Mul;
            myActionMul(25, 13);
            Action<double, double> myActionDiv = Div;
            myActionDiv(12, 45);
            Console.ReadKey();
        }
        static void Add(int a, int b)
        {
            Console.WriteLine($"The Addition is: {a + b}");
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine($"The Subtraction is: {a - b}");
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine($"The Multiplication is: {a * b}");
        }
        static void Div(double a, double b)
        {
            Console.WriteLine($"The Division is: {a / b}");
        }
    }
}
