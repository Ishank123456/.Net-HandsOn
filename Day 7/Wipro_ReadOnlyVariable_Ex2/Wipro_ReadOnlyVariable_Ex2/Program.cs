using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ReadOnlyVariable_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point objPoint1 = new Point();
            objPoint1.x = 55;
            Console.WriteLine($"X: {objPoint1.x}   Y: {objPoint1.y}   Z: {objPoint1.z}");

            Point objPoint2 = new Point(11, 12, 13);
            Console.WriteLine($"X: {objPoint2.x}   Y: {objPoint2.y}   Z: {objPoint2.z}");

            Console.ReadLine();
        }
    }
}
