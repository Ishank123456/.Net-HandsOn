using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================Area of Rectangle===================");
            Console.WriteLine("==========================Integer Area==========================");
            Area<int> objIntArea = new Area<int>();
            Console.WriteLine("Enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area = objIntArea.AreaRectangle(length, width);
            Console.WriteLine($"The Area of Rectangle is: {area}");

            Console.WriteLine("==========================Float Area==========================");
            Area<float> objFloatArea = new Area<float>();
            Console.WriteLine("Enter length in float: ");
            float floatLength = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width in float: ");
            float floatWidth = float.Parse(Console.ReadLine());
            float floatArea = objFloatArea.AreaRectangle(floatLength, floatWidth);
            Console.WriteLine($"The Area of Rectangle is: {floatArea}");

            Console.WriteLine("==========================Decimal Area==========================");
            Area<decimal> objDecimalArea = new Area<decimal>();
            Console.WriteLine("Enter length in decimal: ");
            decimal decimalLength = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter width in decimal: ");
            decimal decimalWidth = Convert.ToDecimal(Console.ReadLine());
            decimal decimalArea = objDecimalArea.AreaRectangle(decimalLength, decimalWidth);
            Console.WriteLine($"The Area of Rectangle is: {decimalArea}");
            Console.ReadLine();


            Console.WriteLine("===================Area of Square===================");
            Console.WriteLine("==========================Integer Area==========================");
            Area<int> objIntAreaSq = new Area<int>();
            Console.WriteLine("Enter side: ");
            int side = Convert.ToInt32(Console.ReadLine());
            int areaSq = objIntAreaSq.AreaSquare(side);
            Console.WriteLine($"The Area of Square is: {areaSq}");

            Console.WriteLine("==========================Float Area==========================");
            Area<float> objFloatAreaSq = new Area<float>();
            Console.WriteLine("Enter side: ");
            float floatSide = float.Parse(Console.ReadLine());
            float floatAreaSq = objFloatAreaSq.AreaSquare(floatSide);
            Console.WriteLine($"The Area of Square is: {floatAreaSq}");

            Console.WriteLine("==========================Decimal Area==========================");
            Area<decimal> objDecimalAreaSq = new Area<decimal>();
            Console.WriteLine("Enter side: ");
            decimal decimalSide = Convert.ToDecimal(Console.ReadLine());
            decimal decimalAreaSq = objDecimalAreaSq.AreaSquare(decimalSide);
            Console.WriteLine($"The Area of Square is: {decimalAreaSq}");

            Console.ReadLine();
        }
    }
}
