
namespace Wipro_AbstractClass_Ex2
{
    public class Area : AbstractArea
    {
        public override double AreaSquare(double side)
        {
            return side * side;
        }
        public override double AreaRectangle(double length, double width)
        {
            return length * width;
        }
        public override double AreaTriangle(double height, double baseLength)
        {
            return 0.5d * height * baseLength;
        }
        public override double AreaCircle(double radius)
        {
            return 3.14d * radius * radius;
        }
    }
}
