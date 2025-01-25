using System;

namespace Wipro_AnonymousDelegate_Ex2
{
    public delegate double AreaRectangleDelegate(double length, double width);
    public delegate double AreaCircleDelegate(double radius);
    public delegate double AreaSquareDelegate(double side);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Area of Rectangle===========================");

            AreaRectangleDelegate objAreaRectangleDelegate = delegate (double _length, double _width)
            {
                return _length * _width;
            };
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = objAreaRectangleDelegate(length, width);
            Console.WriteLine($"The Area of Rectangle: {areaRectangle}");


            Console.WriteLine("===========================Area of Circle===========================");

            AreaCircleDelegate objAreaCircleDelegate = delegate (double _radius)
            {
                return 3.14d * _radius * _radius;
            };
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCircle = objAreaCircleDelegate(radius);
            Console.WriteLine($"The Area of Circle: {areaCircle}");


            Console.WriteLine("===========================Area of Square===========================");

            AreaSquareDelegate objAreaSquareDelegate = delegate (double _side)
            {
                return _side * _side;
            };
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaSquare = objAreaSquareDelegate(side);
            Console.WriteLine($"The Area of Square: {areaSquare}");

            Console.ReadLine();
        }
    }
}
