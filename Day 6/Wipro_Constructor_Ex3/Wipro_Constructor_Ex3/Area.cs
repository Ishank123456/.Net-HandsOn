using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constructor_Ex3
{
    public class Area
    {
        public Area()
        {
            Console.WriteLine("Area Constructor Invoked");
        }
        public double AreaSquare(double side)
        {
            return side * side;
        }
        public double AreaRectangle(double length, double width)
        {
            return length * width;
        }
    }
}
