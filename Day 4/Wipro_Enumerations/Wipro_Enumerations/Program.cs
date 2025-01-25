using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Enumerations
{
    internal class Program
    {
        public enum Days { Monday = 1, Tuesday, Wednesday, Thursday = 54, Friday, Saturday, Sunday }
        static void Main(string[] args)
        {
            int mon = (int)Days.Monday;
            int tues = (int)Days.Tuesday;
            int wed = (int)Days.Wednesday;
            int thurs = (int)Days.Thursday;
            int fri = (int)Days.Friday;
            int sat = (int)Days.Saturday;
            int sun = (int)Days.Sunday;

            Console.WriteLine($"The index of Monday would be: {mon}");
            Console.WriteLine($"The index of Tuesday would be: {tues}");
            Console.WriteLine($"The index of Wednesday would be: {wed}");
            Console.WriteLine($"The index of Thursday would be: {thurs}");
            Console.WriteLine($"The index of Friday would be: {fri}");
            Console.WriteLine($"The index of Saturday would be: {sat}");
            Console.WriteLine($"The index of Sunday would be: {sun}");

            Console.WriteLine("=============Enum by using foreach loop=============");
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine($"The Day would be: {s}");    
            }

            Console.WriteLine("=============Index and Value of an Enum=============");
            int num = (int)Days.Monday;
            string str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Tuesday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Wednesday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Thursday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Friday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Saturday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            num = (int)Days.Sunday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index: {num} Value: {str}");

            Console.ReadLine();
        }
    }
}
