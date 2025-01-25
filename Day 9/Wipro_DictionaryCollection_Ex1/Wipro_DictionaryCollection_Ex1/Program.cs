using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DictionaryCollection_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Rahul");
            myDictionary.Add(2, "Subham");
            myDictionary.Add(3, "Madhu");
            myDictionary.Add(4, "Rahul");
            myDictionary.Add(5, "Somnath");
            myDictionary.Add(6, "Lavanya");
            myDictionary.Add(7, "Animesh");

            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}   Value: {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
