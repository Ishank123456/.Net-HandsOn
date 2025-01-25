using System;

namespace Wipro_MethodOverriding_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle objRectangle = new Rectangle(length, width);
            Console.WriteLine($"The Area of Rectangle would be: {objRectangle.Area()}");

            Console.ReadLine();
        }
    }
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double _length, double _width)
        {
            length = _length;
            width = _width;
        }
        public override double Area()
        {
            return length * width;
        }
    }
}
