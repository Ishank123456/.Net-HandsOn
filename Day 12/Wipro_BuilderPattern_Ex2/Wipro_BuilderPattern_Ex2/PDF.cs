using System;

namespace Wipro_BuilderPattern_Ex2
{
    public class PDF : IConverter
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting-----------");
            Console.WriteLine("File Converted to PDF");
        }
    }
}
