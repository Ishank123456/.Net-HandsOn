using System;

namespace Wipro_BuilderPattern_Ex2
{
    public class Excel : IConverter
    {
        public void ConvertFile()
        {
            Console.WriteLine("Converting-----------");
            Console.WriteLine("Converted to Excel");
        }
    }
}
