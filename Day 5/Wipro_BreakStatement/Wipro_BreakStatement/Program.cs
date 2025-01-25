using System;

namespace Wipro_BreakStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
