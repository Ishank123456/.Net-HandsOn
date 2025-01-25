using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Function_Ex1_WithoutReturnTypeAndPassingParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOpeartion objArithmeticOpeartion = new ArithmeticOpeartion();
            objArithmeticOpeartion.Addition();
            objArithmeticOpeartion.Subtraction();
            objArithmeticOpeartion.Multiplication();
            objArithmeticOpeartion.Division();
            Console.ReadLine();
        }
    }

    public class ArithmeticOpeartion
    {
        public void Addition()
        {
            int a = 30;
            int b = 20;
            int result = a + b;
            Console.WriteLine($"The Addition would be: {result}");
        }
        public void Subtraction()
        {
            int a = 67;
            int b = 45;
            int result = a - b;
            Console.WriteLine($"The Subtraction would be: {result}");
        }
        public void Multiplication()
        {
            int a = 5;
            int b = 47;
            int result = a * b;
            Console.WriteLine($"The Multiplication would be: {result}");
        }
        public void Division()
        {
            int a = 88;
            int b = 4;
            int result = a / b;
            Console.WriteLine($"The Division would be: {result}");
        }
    }
}
