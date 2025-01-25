using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ArrayListCollection_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrCollectionIntilizerArrayList = new ArrayList()
            {
                1,
                "Wipro",
                3.67f,
                " ",
                true,
                'A',
                null,
                12582d
            };

            Console.WriteLine("====================Accessing the Elements by using Foreach Loop====================");
            foreach (var item in arrCollectionIntilizerArrayList)
            {
                Console.WriteLine($"The item in the Array List is: {item}");
            }

            Console.WriteLine("====================Accessing the Elements by using For Loop====================");
            for (int i = 0; i < arrCollectionIntilizerArrayList.Count; i++)
            {
                Console.WriteLine($"The item in the Array List is: {arrCollectionIntilizerArrayList[i]}");
            }

            Console.ReadLine();
        }
    }
}
