using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_EnumWithSwitch
{
    internal class Program
    {
        public enum WeekDays { Sunday, Monday, Tuesday, Thursday, Friday, Saturday}
        static void Main(string[] args)
        {
            int dayIndex = (int)WeekDays.Tuesday;
            switch(dayIndex)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
            Console.ReadLine();
        }
    }
}
