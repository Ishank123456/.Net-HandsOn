using System;

namespace Wipro_Array_Example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] gender = { 'm', 'f', 'm', 'm', 'f', 'f', 'm', 'f', 'm', 'f', 'f' };
            int male = 0, female = 0;
            foreach(char c in gender)
            {
                if (c == 'm')
                    male++;
                else
                    female++;
            }
            Console.WriteLine($"No, of Male: {male}");
            Console.WriteLine($"No. of Female: {female}");
            Console.ReadLine();
        }
    }
}
