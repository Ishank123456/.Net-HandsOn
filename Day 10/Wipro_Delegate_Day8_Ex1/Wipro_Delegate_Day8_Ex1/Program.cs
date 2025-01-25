using System;
using System.Collections.Generic;
using System.Linq;

namespace Wipro_Delegate_Day8_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> hasLength = str => str.Length > 4;
            string[] countries = { "India", "UK", "Germany", "France", "Afghanistan", "USA", "Italy", "China", "Japan", "Russia" };
            IEnumerable<string> country = countries.Where(hasLength);

            foreach(var item in country)
            {
                Console.WriteLine($"The countries with the letters greater than 4 is: {item}");
            }
            Console.ReadLine();
        }
    }
}
