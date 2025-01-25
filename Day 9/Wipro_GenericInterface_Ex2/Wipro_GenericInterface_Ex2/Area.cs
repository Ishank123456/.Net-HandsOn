using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex2
{
    public class Area<T> : IArea<T>
    {
        public T AreaRectangle(T _length, T _width)
        {
            dynamic length = _length;
            dynamic width = _width;
            return length * width;
        }
        public T AreaSquare(T _side)
        {
            dynamic side = _side;
            return side * side;
        }
    }
}
