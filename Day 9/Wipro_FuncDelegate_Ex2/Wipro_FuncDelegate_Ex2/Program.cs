using System;

namespace Wipro_FuncDelegate_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Area of Rectangle===========================");

            Func<double, double, double> myFuncRectangle = delegate (double _length, double _width)
            {
                return _length * _width;
            };
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = myFuncRectangle.Invoke(length, width);
            Console.WriteLine($"The Area of Rectangle: {areaRectangle}");


            Console.WriteLine("===========================Area of Circle===========================");

            Func<double, double> myFuncCircle = delegate (double _radius)
            {
                return 3.14d * _radius * _radius;
            };
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCircle = myFuncCircle.Invoke(radius);
            Console.WriteLine($"The Area of Circle: {areaCircle}");


            Console.WriteLine("===========================Area of Square===========================");

            Func<double, double> myFuncSquare = delegate (double _side)
            {
                return _side * _side;
            };
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaSquare = myFuncSquare.Invoke(side);
            Console.WriteLine($"The Area of Square: {areaSquare}");

            Console.ReadLine();
        }
    }
}
