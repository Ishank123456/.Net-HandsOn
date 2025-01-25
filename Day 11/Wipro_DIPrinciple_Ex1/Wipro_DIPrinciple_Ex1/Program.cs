using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DIPrinciple_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer objComputer = new Computer(new Processor(10, 20));

            Console.ReadLine();
        }
    }

    public class Computer
    {
        Processor processor;
        public Computer(Processor _processor)
        {
            processor = _processor;
            Console.WriteLine("Computer Class is Called");
        }
    }
    public class Processor
    {
        public Processor(int speed1, int speed2)
        {
            Console.WriteLine(speed1);
            Console.WriteLine(speed2);
            Console.WriteLine("Processor Class is Called");
        }
    }
}
