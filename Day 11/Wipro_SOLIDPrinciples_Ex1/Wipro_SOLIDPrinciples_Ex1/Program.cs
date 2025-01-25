using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SOLIDPrinciples_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database objDatabase = new Database();

            objDatabase.Send('A');
            Console.WriteLine($"Receiving: {objDatabase.Recv()}");
            objDatabase.Dial("7384741470");
            Console.WriteLine($"Hanging Up: {objDatabase.HangUp()}");

            Console.ReadLine();
        }
    }
}
