
namespace Wipro_Interface_Ex2
{
    public class Area : IArea
    {
        public double AreaSquare(double side)
        {
            return side * side;
        }
        public double AreaRectangle(double length, double width)
        {
            return length * width;
        }
        public double AreaTriangle(double height, double baseLength)
        {
            return 0.5d * height * baseLength;
        }
        public double AreaCircle(double radius)
        {
            return 3.14d * radius * radius;
        }
    }
}
