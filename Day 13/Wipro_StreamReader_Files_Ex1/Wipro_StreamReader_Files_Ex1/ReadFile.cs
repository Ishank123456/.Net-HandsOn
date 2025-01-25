using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StreamReader_Files_Ex1
{
    public class ReadFile
    {
        public void DataReading()
        {
            StreamReader sr = new StreamReader("C://Users//hp//myFile.txt");

            Console.WriteLine("Content of the File");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

            sr.Close();
        }
    }
}
