using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_BuilderDesignPattern_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director objDirector = new Director();

            IBuilder build1 = new Mercedes();
            objDirector.ConstructCar(build1);

            IBuilder build2 = new Audi();
            objDirector.ConstructCar(build2);

            Console.ReadLine();
        }
    }
}
