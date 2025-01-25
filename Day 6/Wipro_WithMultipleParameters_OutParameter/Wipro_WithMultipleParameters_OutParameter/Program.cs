using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_WithMultipleParameters_OutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum, sub, mul, div;
            Program objProgram = new Program();
            objProgram.Arithmetic(num1, num2, out sum, out sub, out mul, out div);

            Console.WriteLine("======Value received after the function======");
            Console.WriteLine($"Addition: {sum}  Substraction: {sub}  Multiplication: {mul}  Division: {div}");

            Console.ReadLine();
        }

        public void Arithmetic(int num1, int num2, out int sum, out int sub, out int mul, out int div)
        {
            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("======Inside the Function======");
            Console.WriteLine($"Addition: {sum}  Substraction: {sub}  Multiplication: {mul}  Division: {div}");
        }
    }
}
