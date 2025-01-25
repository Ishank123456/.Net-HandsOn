using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericInterface_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================Integer Sum======================");
            ArithmeticOperations<int> objArithmeticOpeartions = new ArithmeticOperations<int>();
            int sum = objArithmeticOpeartions.Add(156, 76);
            Console.WriteLine($"The Addition would be: {sum}");

            Console.WriteLine("======================Float Sum======================");
            ArithmeticOperations<float> objArithmeticOpeartionsFloat = new ArithmeticOperations<float>();
            float sumFloat = objArithmeticOpeartionsFloat.Add(87.96f, 67.567f);
            Console.WriteLine($"The Addition would be: {sumFloat}");

            Console.ReadLine();

        }
    }
}
