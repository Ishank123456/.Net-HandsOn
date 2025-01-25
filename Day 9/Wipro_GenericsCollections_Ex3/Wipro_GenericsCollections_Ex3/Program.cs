using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericsCollections_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations objArithmeticOpeartions = new ArithmeticOperations();

            int sum = objArithmeticOpeartions.Operations<int>(45, 55);
            Console.WriteLine(sum);

            float sumfloat = objArithmeticOpeartions.Operations<float>(134.5f, 45.89f);
            Console.WriteLine(sumfloat);

            string fullName = objArithmeticOpeartions.Operations<string>("Subham ", "Chakraborty");
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
    public class ArithmeticOperations
    {
        public T Operations<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }
    }
}
