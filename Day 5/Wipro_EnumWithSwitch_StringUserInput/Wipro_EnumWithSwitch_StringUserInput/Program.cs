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
                    Console.WriteLine($"The index is {(int)WeekDays.Tuesday}");
                    break;
                case "Wednesday":
                    Console.WriteLine($"The index is {(int)WeekDays.Wednesday}");
                    break;
                case "Thursday":
                    Console.WriteLine($"The index is {(int)WeekDays.Thursday}");
                    break;
                case "Friday":
                    Console.WriteLine($"The day is {(int)WeekDays.Friday}");
                    break;
                case "Saturday":
                    Console.WriteLine($"The day is {(int)WeekDays.Saturday}");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
