using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex2
{
    public interface IArea<T>
    {
        T AreaRectangle(T _length, T _width);
        T AreaSquare(T _side);
    }
}
