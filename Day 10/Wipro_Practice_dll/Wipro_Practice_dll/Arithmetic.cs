
namespace Wipro_Practice_dll
{
    public class Arithmetic : AbstractArithmetic
    {
        public override double Add(double num1, double num2)
        {
            return num1 + num2; 
        }
        public override double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public override double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        public override double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
