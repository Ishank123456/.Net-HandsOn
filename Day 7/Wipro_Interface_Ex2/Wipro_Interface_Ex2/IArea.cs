using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Ex2
{
    public interface IArea
    {
        double AreaSquare(double side);
        double AreaRectangle(double length, double width);
        double AreaTriangle(double height, double baseLength);
        double AreaCircle(double radius);
    }
}
