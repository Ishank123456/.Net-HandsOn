using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public class BollywoodAnimation : IBollywoodMovie
    {
        public override string MovieName
        {
            get
            {
                return "Kalki 2898 AD";
            }
        }
    }
}
