using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_EnumStatus
{
    internal class Program
    {
        public enum Status { Active, Inactive, Opened, Closed, Hold }
        static void Main(string[] args)
        {
            int active = (int)Status.Active;
            int inactive = (int)Status.Inactive;
            int open = (int)Status.Opened;
            int close = (int)Status.Closed;
            int hold = (int)Status.Hold;

            Console.WriteLine("=============Enum by using foreach loop=============");
            foreach (string s in Enum.GetNames(typeof(Status)))
            {
                Console.WriteLine($"The Status is: {s}");
            }

            Console.WriteLine("=============Index and Value of the Enum=============");
            string str = Enum.GetName(typeof(Status), active);
            Console.WriteLine($"Index: {active}    Status: {str}");

            str = Enum.GetName(typeof(Status), inactive);
            Console.WriteLine($"Index: {inactive}    Status: {str}");

            str = Enum.GetName(typeof(Status), open);
            Console.WriteLine($"Index: {open}    Status: {str}");

            str = Enum.GetName(typeof(Status), close);
            Console.WriteLine($"Index: {close}    Status: {str}");

            str = Enum.GetName(typeof(Status), hold);
            Console.WriteLine($"Index: {hold}    Status: {str}");

            Console.ReadLine();
        }
    }
}
