using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StreamWriter_Files_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile obj = new WriteToFile();
            obj.DataWriting();

            Console.ReadLine();
        }
    }
}
