using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Out Parameter=========");

            int val;
            Program objProgram = new Program();
            objProgram.Show(out val);
            Console.WriteLine($"The value received from the function: {val}");

            Console.ReadLine();
        }

        public void Show(out int val)
        {
            int sq = 7;
            val = sq;
            val *= val;
            Console.WriteLine($"The value inside the function: {val}");
        }
    }
}
