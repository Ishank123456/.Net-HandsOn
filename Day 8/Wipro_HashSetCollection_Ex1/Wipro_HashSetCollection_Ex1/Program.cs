using System;
using System.Collections.Generic;

namespace Wipro_HashSetCollection_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> lstNames = new HashSet<string>();
            lstNames.Add("Subham");
            lstNames.Add("Rahul");
            lstNames.Add("Vishal");
            lstNames.Add("Suman");
            lstNames.Add("Rahul");
            lstNames.Add("Meena");
            lstNames.Add("Somnath");
            lstNames.Add("Suman");

            foreach(string str in lstNames)
            {
                Console.WriteLine($"The name would be: {str}");
            }
            Console.ReadLine();
        }
    }
}
