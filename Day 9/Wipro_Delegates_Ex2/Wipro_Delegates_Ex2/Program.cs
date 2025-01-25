using System;

namespace Wipro_Delegates_Ex2
{
    internal class Program
    {
        public delegate int AdditionDelegate(int a, int b);
        public delegate int SubtractionDelegate(int a, int b);
        public delegate int MultiplicationDelegate(int a, int b);
        public delegate int DivisionDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            AdditionDelegate objAdditionDelegate = new AdditionDelegate(Add);
            int sum = objAdditionDelegate.Invoke(a, b);
            Console.WriteLine($"The Addition would be: {sum}");

            AdditionDelegate objSubtractionDelegate = new AdditionDelegate(Sub);
            int sub = objSubtractionDelegate.Invoke(a, b);
            Console.WriteLine($"The Subtraction would be: {sub}");

            AdditionDelegate objMultiplicationDelegate = new AdditionDelegate(Mul);
            int mul = objMultiplicationDelegate.Invoke(a, b);
            Console.WriteLine($"The Multiplication would be: {mul}");

            AdditionDelegate objDivisionDelegate = new AdditionDelegate(Div);
            int div = objDivisionDelegate.Invoke(a, b);
            Console.WriteLine($"The Division would be: {div}");

            Console.ReadLine();

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
