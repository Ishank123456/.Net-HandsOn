using System;

namespace Wipro_MethodOverloading_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            Console.WriteLine("======================Integer======================");
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(a, b)}");

            Console.WriteLine("======================Float======================");
            Console.WriteLine("Enter a1: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b1: ");
            float b1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(a1, b1)}");

            Console.WriteLine("======================Decimal======================");
            Console.WriteLine("Enter a2: ");
            decimal a2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter b2: ");
            decimal b2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(a2, b2)}");

            Console.WriteLine("======================String======================");
            Console.WriteLine("Enter str1: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter str2: ");
            string str2 = Console.ReadLine();

            Console.WriteLine($"The Full Name is: {objArithmetic.Add(str1, str2)}");

            Console.ReadLine();
        }
    }
    public class Arithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public string Add(string str1, string str2)
        {
            return str1 + " " + str2;
        }
    }
}
