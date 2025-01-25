using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_BuilderDesignPattern_Ex1
{
    public class Director
    {
        public void ConstructCar(IBuilder build)
        {
            build.ManufactureCar();
        }
    }
}
