using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the Case Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    break;
                case 9:
                    Console.WriteLine("Case 9");
                    break;
                default:
                    Console.WriteLine("No Match Found");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
