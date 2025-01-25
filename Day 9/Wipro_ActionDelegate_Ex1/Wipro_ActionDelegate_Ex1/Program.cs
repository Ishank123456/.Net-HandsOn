using System;

namespace Wipro_ActionDelegate_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Area of Rectangle===========================");

            Action<double, double> myActionRectangle = delegate (double _length, double _width)
            {
                double _areaRectangle = _length * _width;
                Console.WriteLine($"The Area of Rectangle is: {_areaRectangle}");
            };
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            myActionRectangle.Invoke(length, width);


            Console.WriteLine("===========================Area of Square===========================");

            Action<double> myActionSquare = delegate (double _side)
            {
                double _areaSquare = _side * _side;
                Console.WriteLine($"The Area of Square is: {_areaSquare}");
            };
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            myActionSquare.Invoke(side);


            Console.WriteLine("===========================Area of Circle===========================");

            Action<double> myActionCircle = delegate (double _radius)
            {
                double _areaCircle = 3.14d * _radius * _radius;
                Console.WriteLine($"The Area of Circle is: {_areaCircle}");
            };
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            myActionCircle.Invoke(radius);


            Console.WriteLine("===========================Area of Triangle===========================");

            Action<double, double> myActionTriangle = delegate (double _height, double _baseLength)
            {
                double _areaTriangle = 0.5d * _height * _baseLength;
                Console.WriteLine($"The Area of Triangle is: {_areaTriangle}");
            };
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            myActionTriangle.Invoke(height, baseLength);

            Console.ReadLine();
        }
    }
}
