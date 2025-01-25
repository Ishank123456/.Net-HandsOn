using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public class HorrorMovieFactory : IMovieFactory
    {
        public override IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodHorror();
        }
        public override IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodHorror();
        }
    }
}
