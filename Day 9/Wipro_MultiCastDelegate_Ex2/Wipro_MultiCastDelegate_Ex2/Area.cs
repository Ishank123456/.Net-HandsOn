using System;

namespace Wipro_MultiCastDelegate_Ex2
{
    public class Area
    {
        public void AreaRectangle(double length, double width)
        {
            double areaRectangle = length * width;
            Console.WriteLine($"The Area of Rectangle is: {areaRectangle}");
        }
        public void AreaSquare(double side)
        {
            double areaSquare = side * side;
            Console.WriteLine($"The Area of Square is: {areaSquare}");
        }
        public void AreaCircle(double radius)
        {
            double areaCircle = 3.14d * radius * radius;
            Console.WriteLine($"The Area of Circle is: {areaCircle}");
        }
        public void AreaTriangle(double height, double baseLength)
        {
            double areaTriangle = 0.5d * height * baseLength;
            Console.WriteLine($"The Area of Triangle is: {areaTriangle}");
        }
    }
}
