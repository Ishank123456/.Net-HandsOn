using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex1
{
    public interface IArithmetic<T>
    {
        T Add(T x, T y);
    }
}
