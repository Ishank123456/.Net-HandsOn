using System;

namespace Wipro_Program4_dll_1
{
    public class Area
    {
        public void AreaSquare(int side)
        {
            int result = side * side;
            Console.WriteLine($"The Area of the Square is: {result}");
        }
        public void AreaRectangle(int length, int width)
        {
            int result1 = length * width;
            Console.WriteLine($"The Area of the Rectangle is: {result1}");
        }
        public void AreaTringle(int length1, int width1)
        {
            float result2 = 0.5f * length1 * width1;
            Console.WriteLine($"The Area of the Tringle is: {result2}");
        }
        public void AreaCircle(int radius)
        {
            float result3 = 3.14f * radius * radius;
            Console.WriteLine($"The Area of the Circle is: {result3}");
        }
    }
}
