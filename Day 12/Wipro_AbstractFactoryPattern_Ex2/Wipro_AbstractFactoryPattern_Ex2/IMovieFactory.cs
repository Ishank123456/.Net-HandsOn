using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public abstract class IMovieFactory
    {
        public abstract IHollywoodMovie GetHollywoodMovie();
        public abstract IBollywoodMovie GetBollywoodMovie();
    }
}
