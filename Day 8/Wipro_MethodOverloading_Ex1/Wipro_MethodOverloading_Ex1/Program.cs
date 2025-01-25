using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_MethodOverloading_Ex1
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

            Console.WriteLine("======================Double======================");
            Console.WriteLine("Enter a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(a2, b2)}");

            Console.WriteLine("======================Decimal======================");
            Console.WriteLine("Enter a3: ");
            decimal a3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter b3: ");
            decimal b3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(a3, b3)}");

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
        public double Add(double a, double b)
        {
            return a + b;
        }
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
