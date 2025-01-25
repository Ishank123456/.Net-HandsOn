using System;

namespace Wipro_Function_Ex3_WithParametersAndReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area objArea = new Area();

            Console.WriteLine("=============Area of Square=============");
            Console.WriteLine("Enter the side length: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaSquare = objArea.AreaSquare(side);
            Console.WriteLine($"The Area of the Square is {areaSquare}");

            Console.WriteLine("=============Area of Rectangle=============");
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = objArea.AreaRectangle(length, width);
            Console.WriteLine($"The Area of the Rectangle is {areaRectangle}");

            Console.WriteLine("=============Area of Circle=============");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCircle = objArea.AreaCircle(radius);
            Console.WriteLine($"The Area of the Circle is {areaCircle}");

            Console.ReadLine();
        }
    }
}
