using System;

namespace Wipro_EnumMonths
{
    internal class Program
    {
        public enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December }
        static void Main(string[] args)
        {
            int jan = (int)Months.January;
            int feb = (int)Months.February;
            int mar = (int)Months.March;
            int apr = (int)Months.April;
            int may = (int)Months.May;
            int june = (int)Months.June;
            int jul = (int)Months.July;
            int aug = (int)Months.August;
            int sep = (int)Months.September;
            int oct = (int)Months.October;
            int nov = (int)Months.November;
            int dec = (int)Months.December;

            Console.WriteLine("===============Values of the Enum===============");
            foreach (string s in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine($"The Month would be: {s}");
            }

            Console.WriteLine("===============Index and their Values===============");
            string str = Enum.GetName(typeof(Months), jan);
            Console.WriteLine($"Index: {jan}      Value: {str}");

            str = Enum.GetName(typeof(Months), feb);
            Console.WriteLine($"Index: {feb}      Value: {str}");

            str = Enum.GetName(typeof(Months), mar);
            Console.WriteLine($"Index: {mar}      Value: {str}");

            str = Enum.GetName(typeof(Months), apr);
            Console.WriteLine($"Index: {apr}      Value: {str}");

            str = Enum.GetName(typeof(Months), may);
            Console.WriteLine($"Index: {may}      Value: {str}");

            str = Enum.GetName(typeof(Months), june);
            Console.WriteLine($"Index: {june}      Value: {str}");

            str = Enum.GetName(typeof(Months), jul);
            Console.WriteLine($"Index: {jul}      Value: {str}");

            str = Enum.GetName(typeof(Months), aug);
            Console.WriteLine($"Index: {aug}      Value: {str}");

            str = Enum.GetName(typeof(Months), sep);
            Console.WriteLine($"Index: {sep}      Value: {str}");

            str = Enum.GetName(typeof(Months), oct);
            Console.WriteLine($"Index: {oct}     Value: {str}");

            str = Enum.GetName(typeof(Months), nov);
            Console.WriteLine($"Index: {nov}     Value: {str}");

            str = Enum.GetName(typeof(Months), dec);
            Console.WriteLine($"Index: {dec}     Value: {str}");

            Console.ReadLine();
        }
    }
}
