using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex3
{
    public enum BreadBase
    {
        HotIndianMasalaBase,
        PunjabiTadkaBase,
        ItalianCheeseBase,
        VeggieBase
    }
    public interface Bread
    {
        void Bake();
    }
}
