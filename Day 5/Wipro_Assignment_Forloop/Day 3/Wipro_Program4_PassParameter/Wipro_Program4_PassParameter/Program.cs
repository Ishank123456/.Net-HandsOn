using System;
using Wipro_Program4_dll;
using Wipro_Program4_dll_2;

namespace Wipro_Program4_PassParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            objArithmetic.Addition(15, 30);

            Area objArea = new Area();
            objArea.AreaSquare(10);
            objArea.AreaRectangle(10, 20);
            objArea.AreaTringle(20, 15);
            objArea.AreaCircle(10);
            Console.ReadLine();

        }
    }
}
