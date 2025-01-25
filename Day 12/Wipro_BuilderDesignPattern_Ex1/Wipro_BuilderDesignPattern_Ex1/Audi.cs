using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_BuilderDesignPattern_Ex1
{
    public class Audi : IBuilder
    {
        public void ManufactureCar()
        {
            Console.WriteLine("Audi Q8 E-TRON 55   |   "
                + "Color : Red   |   "
                + "Air Conditioned");
        }
    }
}
