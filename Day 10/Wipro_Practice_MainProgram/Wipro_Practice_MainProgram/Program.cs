using System;
using Wipro_Practice_dll;

namespace Wipro_Practice_MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================Arithmetic Operations==================================");
            Arithmetic objArithmetic = new Arithmetic();
            Console.WriteLine("Enter num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(num1, num2)}");
            Console.WriteLine($"The Subtraction is: {objArithmetic.Sub(num1, num2)}");
            Console.WriteLine($"The Multiplication is: {objArithmetic.Mul(num1, num2)}");
            Console.WriteLine($"The Division is: {objArithmetic.Div(num1, num2)}");


            Console.WriteLine();
            Console.WriteLine("==================================Area==================================");

            Area objArea = new Area();

            Console.WriteLine("==========Area of Square==========");
            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double areaSquare = objArea.AreaSquare(side);
            Console.WriteLine($"The Area of Square is: {areaSquare}");

            Console.WriteLine("==========Area of Circle==========");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaCircle = objArea.AreaCircle(radius);
            Console.WriteLine($"The Area of Circle is: {areaCircle}");

            Console.WriteLine("==========Area of Rectangle==========");
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double areaRectangle = objArea.AreaRectangle(length, width);
            Console.WriteLine($"The Area of Rectangle is: {areaRectangle}");

            Console.WriteLine("==========Area of Triangle==========");
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            double areaTriangle = objArea.AreaTriangle(height, baseLength);
            Console.WriteLine($"The Area of Rectangle is: {areaTriangle}");

            Console.WriteLine();
            Console.WriteLine("==================================Connections==================================");
            Connection objConnection = new Connection();
            string str1 = objConnection.OpenConnection();
            Console.WriteLine(str1);
            string str2 = objConnection.CloseConnection();
            Console.WriteLine(str2);

            Console.ReadLine();
        }
    }
}
