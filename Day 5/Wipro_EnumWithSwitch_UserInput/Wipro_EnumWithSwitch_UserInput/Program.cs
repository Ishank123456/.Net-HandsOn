using System;

namespace Wipro_EnumWithSwitch_UserInput
{
    internal class Program
    {
        public enum WeekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the index value of the day");
            int idx_value = Convert.ToInt32(Console.ReadLine());

            switch (idx_value)
            {
                case 0:
                    string str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 1:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 2:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 3:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 4:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 5:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
                case 6:
                    str = Enum.GetName(typeof(WeekDays), idx_value);
                    Console.WriteLine($"The day is {str}");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
