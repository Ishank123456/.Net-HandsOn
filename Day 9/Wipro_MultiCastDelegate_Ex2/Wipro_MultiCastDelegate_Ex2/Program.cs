using System;

namespace Wipro_MultiCastDelegate_Ex2
{
    internal class Program
    {
        public delegate void AreaRectOrTriDelegate(double lengthOrHeight, double widthOrBase);
        public delegate void AreaSqOrCirDelegate(double sideOrRadius);
        static void Main(string[] args)
        {
            Area objArea = new Area();

            AreaRectOrTriDelegate objAreaRectOrTriDelegate = new AreaRectOrTriDelegate(objArea.AreaRectangle);
            objAreaRectOrTriDelegate += new AreaRectOrTriDelegate(objArea.AreaTriangle);

            AreaSqOrCirDelegate objAreaSqOrCirDelegate = new AreaSqOrCirDelegate(objArea.AreaSquare);
            objAreaSqOrCirDelegate += new AreaSqOrCirDelegate(objArea.AreaCircle);

            objAreaRectOrTriDelegate.Invoke(15, 10);
            objAreaSqOrCirDelegate.Invoke(10);

            Console.ReadLine();
        }
    }
}
