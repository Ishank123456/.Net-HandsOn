using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex3
{
    public class IndianBreadFactory : BreadFactory
    {
        public Bread GetBread(BreadBase BreadBase)
        {
            Bread vBread = null;
            switch(BreadBase)
            {
                case BreadBase.HotIndianMasalaBase:
                    vBread = new HotIndianMasalaBaseBread();
                    break;
                case BreadBase.PunjabiTadkaBase:
                    vBread = new PunjabiTadkaBaseBread();
                    break;
            }
            return vBread;
        }
    }
}
