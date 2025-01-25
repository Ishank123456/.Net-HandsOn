using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndianBreadFactory vIndianBreadFactory = new IndianBreadFactory();
            Bread vBread = vIndianBreadFactory.GetBread(BreadBase.HotIndianMasalaBase);
            vBread.Bake();

            AmericanBreadFactory vAmericanBreadFactory = new AmericanBreadFactory();
            Bread vAmericanBread = vIndianBreadFactory.GetBread(BreadBase.HotIndianMasalaBase);
            vBread.Bake();

            Console.ReadLine();
        }
    }
}
