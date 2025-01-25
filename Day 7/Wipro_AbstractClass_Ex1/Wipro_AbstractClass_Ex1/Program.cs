using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractClass_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            int sum = objArithmetic.Add(10, 20);
            Console.WriteLine($"The Addition would be: {sum}");

            int sub = objArithmetic.Sub(39, 20);
            Console.WriteLine($"The Subtraction would be: {sub}");

            int mul = objArithmetic.Mul(45, 8);
            Console.WriteLine($"The Multiplication would be: {mul}");

            double div = objArithmetic.Div(100, 20);
            Console.WriteLine($"The Division would be: {div}");

            Console.ReadLine();
        }
    }
    public abstract class AbstractArithmetic
    {
        public abstract int Add(int x, int y);
        public abstract int Sub(int x, int y);

        public int Mul(int x, int y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
    }

    public class Arithmetic : AbstractArithmetic
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
        public override int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
