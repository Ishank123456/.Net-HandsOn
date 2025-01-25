using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Function_Ex2_PassingParameters
{
    public class Arithmetic
    {
        public void Addition(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"The Addition would be: {result}");
        }
        public void Subtraction(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"The Substraction would be: {result}");
        }
        public void Multiplication(double a, double b)
        {
            double result = a * b;
            Console.WriteLine($"The Multiplication would be: {result}");
        }
        public void Division(double a, double b)
        {
            double result = a / b;
            Console.WriteLine($"The Division would be: {result}");
        }
    }
}