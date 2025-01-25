using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Function_Ex2_PassingParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number two: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Arithmetic objArithmetic = new Arithmetic();
            objArithmetic.Addition(num1, num2);
            objArithmetic.Subtraction(num1, num2);
            objArithmetic.Multiplication(num1, num2);
            objArithmetic.Division(num1, num2);
            Console.ReadLine();
        }
    }
}
