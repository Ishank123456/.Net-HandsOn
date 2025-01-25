namespace Wipro_Assesment_dll
{
    public class Area
    {   
        public double AreaRectangle(double length, double width)
        {
            double result = length * width;
            return result;
        }
        public double AreaSquare(double side)
        {
            double result = side * side;
            return result;
        }
        public double AreaCircle(double radius)
        {
            double result = 3.14d * radius * radius;
            return result;
        }
        public double AreaTriangle(double height, double baseLength)
        {
            double result = 0.5d * height * baseLength;
            return result;
        }
    }
}
