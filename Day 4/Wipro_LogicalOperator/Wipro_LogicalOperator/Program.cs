using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            bool result;

            result = a && b;
            Console.WriteLine($"The AND operator result would be: {result}");

            result = a || b;
            Console.WriteLine($"The OR operator result would be: {result}");

            result = a != b;
            Console.WriteLine($"The NOT operator result would be: {result}");

            Console.ReadLine();
        }
    }
}
