using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_BuilderDesignPattern_Ex1
{
    public class Mercedes : IBuilder
    {
        public void ManufactureCar()
        {
            Console.WriteLine("Mercedes-Benz   |   "
                + "Color : Black   |   "
                + "Air Conditioned");
        }
    }
}
