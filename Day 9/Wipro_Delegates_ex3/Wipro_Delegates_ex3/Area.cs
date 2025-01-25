
namespace Wipro_Delegates_ex3
{
    public class Area
    {
        public double AreaRectangle(double length, double width)
        {
            return length * width;
        }
        public double AreaSquare(double side)
        {
            return side * side;
        }
        public double AreaCircle(double radius)
        {
            return 3.14d * radius * radius;
        }
        public double AreaTriangle(double height, double baseLength)
        {
            return 0.5d * height * baseLength;
        }
    }
}
