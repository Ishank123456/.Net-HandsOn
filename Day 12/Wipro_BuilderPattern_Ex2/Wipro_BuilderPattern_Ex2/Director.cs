

namespace Wipro_BuilderPattern_Ex2
{
    public class Director
    {
        public void ConvertFiles(IConverter converter)
        {
            converter.ConvertFile();
        }
    }
}
