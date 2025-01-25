
namespace Wipro_Function_Ex3_WithParametersAndReturnType
{
    public class Area
    {
        public double AreaSquare(double side)
        {
            double result = side * side;
            return result;
        }
        public double AreaRectangle(double length, double width)
        {
            double result = length * width;
            return result;
        }
        public double AreaCircle(double radius)
        {
            double result = 3.14d * radius * radius;
            return result;
        }
    }
}
