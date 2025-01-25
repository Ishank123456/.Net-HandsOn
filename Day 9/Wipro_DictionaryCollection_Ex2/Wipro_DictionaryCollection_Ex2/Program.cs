using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DictionaryCollection_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "Rahul"}, {2, "Subham"}, {3, "Madhu"}, {4, "Rahul"}, {5, "Somnath"}, {6, "Lavanya"}, {7, "Animesh"}
            };

            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine($"Key; {kvp.Key}   Value: {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
