using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_DesignPattern_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = Arithmetic.GetArithmetic;

            Console.WriteLine("Enter num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(num1, num2)}");
            Console.WriteLine($"The Subtraction is: {objArithmetic.Sub(num1, num2)}");
            Console.WriteLine($"The Multiplication is: {objArithmetic.Mul(num1, num2)}");
            Console.WriteLine($"The Division is: {objArithmetic.Div(num1, num2)}");

            Console.ReadLine();
        }
    }
}
