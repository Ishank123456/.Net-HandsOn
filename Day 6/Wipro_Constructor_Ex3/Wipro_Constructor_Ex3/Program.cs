using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constructor_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area objArea1 = new Area();

            Console.WriteLine("=============Object One=============");
            Console.WriteLine("Enter the length of the side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of Square: {objArea1.AreaSquare(side)}");

            Console.WriteLine("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of Rectangle is: {objArea1.AreaRectangle(length, width)}");
            Console.WriteLine();

            Area objArea2 = new Area();

            Console.WriteLine("=============Object Two=============");
            Console.WriteLine("Enter the length of the side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of Square: {objArea1.AreaSquare(side1)}");

            Console.WriteLine("Enter the length: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of Rectangle is: {objArea1.AreaRectangle(length1, width1)}");

            Console.ReadLine();
        }
    }
}
