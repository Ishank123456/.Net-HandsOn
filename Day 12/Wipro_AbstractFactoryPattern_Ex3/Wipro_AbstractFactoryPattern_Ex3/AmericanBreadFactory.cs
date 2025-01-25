using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex3
{
    public class AmericanBreadFactory : BreadFactory
    {
        public Bread GetBread(BreadBase BreadBase)
        {
            Bread vBread = null;
            switch (BreadBase)
            {
                case BreadBase.ItalianCheeseBase:
                    vBread = new ItalianCheeseBaseBread();
                    break;
                case BreadBase.VeggieBase:
                    vBread = new VeggieBaseBread();
                    break;
            }
            return vBread;
        }
    }
}
