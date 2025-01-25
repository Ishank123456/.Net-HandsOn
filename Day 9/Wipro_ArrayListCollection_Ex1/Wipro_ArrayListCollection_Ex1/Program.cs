using System;
using System.Collections;

namespace Wipro_ArrayListCollection_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Wipro");
            arrList.Add(2.345f);
            arrList.Add(" ");
            arrList.Add(true);
            arrList.Add('A');
            arrList.Add(null);

            Console.WriteLine("====================Accessing the Elements by using Foreach Loop====================");
            foreach (var item in arrList)
            {
                Console.WriteLine($"The item in the Array List is: {item}");
            }

            Console.WriteLine("====================Accessing the Elements by using For Loop====================");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine($"The item in the Array List is: {arrList[i]}");
            }

            Console.ReadLine();
        }
    }
}
