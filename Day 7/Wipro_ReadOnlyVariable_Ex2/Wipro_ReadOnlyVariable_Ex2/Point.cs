using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ReadOnlyVariable_Ex2
{
    public class Point
    {
        public int x;
        public readonly int y = 25;
        public readonly int z;

        public Point()
        {
            z = 50;
        }
        public Point(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
}
