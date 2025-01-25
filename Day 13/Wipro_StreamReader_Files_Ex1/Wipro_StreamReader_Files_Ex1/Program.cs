using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StreamReader_Files_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile objReadFile = new ReadFile();
            objReadFile.DataReading();
            Console.ReadLine();
        }
    }
}
