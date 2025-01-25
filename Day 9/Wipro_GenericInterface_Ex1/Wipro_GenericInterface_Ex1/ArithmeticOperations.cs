using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex1
{
    public class ArithmeticOperations<T> : IArithmetic<T>
    {
        public T Add(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }
    }
}
