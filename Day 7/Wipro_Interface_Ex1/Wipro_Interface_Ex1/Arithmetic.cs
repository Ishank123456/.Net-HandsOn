
namespace Wipro_Interface_Ex1
{
    public class Arithmetic : IArithmetic
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
