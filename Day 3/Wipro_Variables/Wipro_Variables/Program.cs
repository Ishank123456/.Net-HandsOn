using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 90;
            int j = 80;
            int k = 70;
            Console.WriteLine("=========Int Data Type=========");
            Console.WriteLine($"The variable of i, j and k would be: {i} {j} {k}");
            Console.WriteLine("The variable of i, j and k would be: " + i +" " + j + " "+ k);
            Console.WriteLine("The variable of i, j and k would be: {0} {1} {2}", i, j, k);

            string str = "Wipro";
            Console.WriteLine("=========String Data Type=========");
            Console.WriteLine($"The variable str would be: {str}");
            Console.WriteLine("The variable str would be: " + str);
            Console.WriteLine("The variable str would be: {0}", str);

            float f = 67.897f;
            Console.WriteLine("=========Float Data Type=========");
            Console.WriteLine($"The variable f would be: {f}");
            Console.WriteLine("The variable f would be: " + f);
            Console.WriteLine("The variable f would be: {0}", f);

            double d = 987654.89787d;
            Console.WriteLine("=========Double Data Type=========");
            Console.WriteLine($"The variable d would be: {d}");
            Console.WriteLine("The variable d would be: " + d);
            Console.WriteLine("The variable d would be: {0}", d);

            decimal d1 = 87654534215.76585439m;
            Console.WriteLine("=========Decimal Data Type=========");
            Console.WriteLine($"The variable d1 would be: {d1}");
            Console.WriteLine("The variable d1 would be: " + d1);
            Console.WriteLine("The variable d1 would be: {0}", d1);

            char ch = 'A';
            Console.WriteLine("=========Character Data Type=========");
            Console.WriteLine($"The variable ch would be: {ch}");
            Console.WriteLine("The variable ch would be: " + ch);
            Console.WriteLine("The variable ch would be: {0}", ch);

            bool isActivated = true;
            Console.WriteLine("=========Boolean Data Type=========");
            Console.WriteLine($"The variable isActivated would be: {isActivated}");
            Console.WriteLine("The variable isActivated would be: " + isActivated);
            Console.WriteLine("The variable isActivated would be: {0}", isActivated);

            Console.ReadLine();
        }
    }
}
