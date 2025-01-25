using System;

namespace Wipro_BuilderPattern_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director objDirector = new Director();

            IConverter PdfConverter = new PDF();
            objDirector.ConvertFiles(PdfConverter);
            Console.WriteLine();

            IConverter ExcelConverter = new Excel();
            objDirector.ConvertFiles(ExcelConverter);
            Console.WriteLine();

            IConverter WordConverter = new Word();
            objDirector.ConvertFiles(WordConverter);

            Console.ReadLine();
        }
    }
}
