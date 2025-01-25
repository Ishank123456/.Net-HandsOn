using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_DesignPattern_Ex3
{
    public sealed class Arithmetic
    {
        private Arithmetic()
        {

        }
        private static Arithmetic arithmetic;

        public static Arithmetic GetArithmetic
        {
            get
            {
                if (arithmetic == null)
                {
                    arithmetic = new Arithmetic();
                }
                return arithmetic;
            }
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
