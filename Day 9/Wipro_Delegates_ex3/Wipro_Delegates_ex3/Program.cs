using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Delegates_ex3
{
    internal class Program
    {
        public delegate double AreaRectangleDelegate(double length, double width);
        public delegate double AreaSquareDelegate(double side);
        public delegate double AreaCircleDelegate(double radius);
        public delegate double AreaTriangleDelegate(double height, double baseLength);
        static void Main(string[] args)
        {
            Area objArea = new Area();

            Console.WriteLine("======================Area of Rectangle======================");
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            AreaRectangleDelegate objAreaRectangleDelegate = new AreaRectangleDelegate(objArea.AreaRectangle);
            double areaRectangle = objAreaRectangleDelegate.Invoke(length, width);
            Console.WriteLine($"The Area of Rectangle is: {areaRectangle}");



            Console.WriteLine("======================Area of Square======================");
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());

            AreaSquareDelegate objAreaSquareDelegate = new AreaSquareDelegate(objArea.AreaSquare);
            double areaSquare = objAreaSquareDelegate.Invoke(side);
            Console.WriteLine($"The Area of Square is: {areaSquare}");



            Console.WriteLine("======================Area of Circle======================");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            AreaCircleDelegate objAreaCircleDelegate = new AreaCircleDelegate(objArea.AreaCircle);
            double areaCircle = objAreaCircleDelegate.Invoke(radius);
            Console.WriteLine($"The Area of Circle is: {areaCircle}");



            Console.WriteLine("======================Area of Triangle======================");
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter base length: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            AreaTriangleDelegate objAreaTriangleDelegate = new AreaTriangleDelegate(objArea.AreaTriangle);
            double areaTriangle = objAreaTriangleDelegate.Invoke(length, width);
            Console.WriteLine($"The Area of Triangle is: {areaTriangle}");


            Console.ReadLine();
        }
    }
}
