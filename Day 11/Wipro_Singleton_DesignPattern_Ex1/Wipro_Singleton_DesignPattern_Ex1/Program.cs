using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_DesignPattern_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Console.ReadLine();
        }
    }
}
