using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_EnumWithSwitch_StringUserInput
{
    internal class Program
    {
        public enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter the day: ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Sunday":
                    Console.WriteLine($"The index is {(int)WeekDays.Sunday}");
                    break;
                case "Monday":
                    Console.WriteLine($"The index is {(int)WeekDays.Monday}");
                    break;
                case "Tuesday":
                    Console.WriteLine($"The index is {i}");
                    break;
                case "Wednesday":
                    Console.WriteLine($"The index is {i}");
                    break;
                case "Thursday":
                    Console.WriteLine($"The index is {i}");
                    break;
                case "Friday":
                    Console.WriteLine($"The day is {i}");
                    break;
                case "Saturday":
                    Console.WriteLine($"The day is {i}");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
