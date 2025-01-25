using System;

namespace Wipro_AbstractClass_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area objArea = new Area();

            Console.WriteLine("======================Area of Square======================");
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of the Square: {objArea.AreaSquare(side)}");

            Console.WriteLine("======================Area of Rectangle======================");
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of the Rectangle: {objArea.AreaRectangle(length, width)}");

            Console.WriteLine("======================Area of Triangle======================");
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of the Triangle: {objArea.AreaTriangle(height, baseLength)}");

            Console.WriteLine("======================Area of Circle======================");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Area of the Circle: {objArea.AreaCircle(radius)}");

            Console.ReadLine();
        }
    }
}
