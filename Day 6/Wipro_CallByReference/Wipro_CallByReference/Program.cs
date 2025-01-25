using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_CallByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Call By Reference=========");
            int val = 70;
            Console.WriteLine($"The value before passing to the function: {val}");

            Program objProgram = new Program();
            objProgram.Show(ref val);
            Console.WriteLine($"The value after passing to the function: {val}");

            Console.ReadLine();
        }

        public void Show(ref int val)
        {
            val *= val;
            Console.WriteLine($"The value inside the function: {val}");
        }
    }
}
