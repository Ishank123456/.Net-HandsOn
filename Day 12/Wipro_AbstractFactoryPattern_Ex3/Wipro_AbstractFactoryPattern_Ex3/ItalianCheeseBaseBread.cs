using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex3
{
    public class ItalianCheeseBaseBread : Bread
    {
        public void Bake()
        {
            Console.WriteLine("Italian Cheese Base Bread");
        }
    }
}
