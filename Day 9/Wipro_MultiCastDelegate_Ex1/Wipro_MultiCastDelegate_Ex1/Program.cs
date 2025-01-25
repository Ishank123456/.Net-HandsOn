using System;

namespace Wipro_MultiCastDelegate_Ex1
{
    internal class Program
    {
        public delegate void ArithmeticDelegate(double a, double b);
        static void Main(string[] args)
        {
            ArithmeticDelegate objArithmeticDelegate = new ArithmeticDelegate(Add);
            objArithmeticDelegate += new ArithmeticDelegate(Sub);
            objArithmeticDelegate += new ArithmeticDelegate(Mul);
            objArithmeticDelegate += new ArithmeticDelegate(Div);

            objArithmeticDelegate.Invoke(250, 50);

            Console.ReadLine();
        }
        public static void Add(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"The Addition is: {sum}");
        }
        public static void Sub(double a, double b)
        {
            double sub = a - b;
            Console.WriteLine($"The Subtraction is: {sub}");
        }
        public static void Mul(double a, double b)
        {
            double mul = a * b;
            Console.WriteLine($"The Multiplication is: {mul}");
        }
        public static void Div(double a, double b)
        {
            double div = a / b;
            Console.WriteLine($"The Division is: {div}");
        }
    }
    
}
