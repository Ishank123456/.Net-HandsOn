using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_GradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (marks >= 0 && marks < 40)
            {
                Console.WriteLine("Failed");
            }
            else if(marks >= 40 && marks < 50)
            {
                Console.WriteLine('C');
            }
            else if (marks >= 50 && marks < 65)
            {
                Console.WriteLine('B');
            }
            else if (marks >= 65 && marks < 75)
            {
                Console.WriteLine('A');
            }
            else if (marks >= 75 && marks < 95)
            {
                Console.WriteLine("A++");
            }
            else if (marks >= 95)
            {
                Console.WriteLine("Outstanding");
            }

            Console.ReadLine();
            goto start;
        }
    }
}
