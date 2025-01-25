using System;

namespace Wipro_Interface_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            Console.WriteLine($"The Addition would be: {objArithmetic.Add(20, 10)}");
            Console.WriteLine($"The Subtraction would be: {objArithmetic.Sub(20, 10)}");
            Console.WriteLine($"The Multiplication would be: {objArithmetic.Mul(20, 10)}");
            Console.WriteLine($"The Division would be: {objArithmetic.Div(250, 10)}");

            Console.ReadLine();
        }
    }
}
