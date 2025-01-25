using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StreamWriter_Files_Ex1
{
    public class WriteToFile
    {
        public void DataWriting()
        {
            StreamWriter sw = new StreamWriter("C://Users//hp//myFile.txt");

            Console.WriteLine("Enter the test you want to write on the file: ");

            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
