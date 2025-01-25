using System;
using Wipro_ClassLib_dll;

namespace Wipro_Program_Using_Class_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area objArea = new Area();
            objArea.AreaSquare();
            objArea.AreaRectangle();
            objArea.AreaTringle();
            objArea.AreaCircle();

            Console.ReadLine();
        }
    }
}
