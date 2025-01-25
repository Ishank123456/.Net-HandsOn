using System;
using System.Collections.Generic;

namespace Wipro_ListCollections_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lstNames = new List<string>();
            lstNames.Add("Subham");
            lstNames.Add("Rahul");
            lstNames.Add("Vishal");
            lstNames.Add("Suman");
            lstNames.Add("Rahul");
            lstNames.Add("Meena");
            lstNames.Add("Somnath");
            lstNames.Add("Suman");

            foreach (string str in lstNames)
            {
                Console.WriteLine($"The name would be: {str}");
            }

            Console.ReadLine();
        }
    }
}
