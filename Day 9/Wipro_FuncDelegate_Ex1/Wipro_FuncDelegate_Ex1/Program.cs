using System;

namespace Wipro_FuncDelegate_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> myFuncAdd = Add;
            double sum = myFuncAdd.Invoke(20, 10);
            Console.WriteLine($"The Addition is: {sum}");

            Func<double, double, double> myFuncSub = Sub;
            double sub = myFuncSub.Invoke(89, 26);
            Console.WriteLine($"The Subtraction is: {sub}");

            Func<double, double, double> myFuncMul = Mul;
            double mul = myFuncMul.Invoke(15, 9);
            Console.WriteLine($"The Multiplication is: {mul}");

            Func<double, double, double> myFuncDiv = Div;
            double div = myFuncDiv.Invoke(49, 7);
            Console.WriteLine($"The Division is: {div}");

            Console.ReadLine();
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
