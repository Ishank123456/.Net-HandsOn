using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public class BollywoodHorror : IBollywoodMovie
    {
        public override string MovieName
        {
            get
            {
                return "1920";
            }
        }
    }
}
