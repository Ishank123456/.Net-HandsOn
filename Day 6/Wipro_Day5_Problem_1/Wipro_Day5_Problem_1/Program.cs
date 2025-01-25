using System;


namespace Wipro_Day5_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string s = Convert.ToString(a);
            string res = "";

            if (s[0] != '0')
            {
                res = '0' + s;
            }
            else
            {
                res = s;
            } 
            Console.WriteLine($"The new number is {res}");
            Console.ReadLine();
            goto start;
        }
    }
}
