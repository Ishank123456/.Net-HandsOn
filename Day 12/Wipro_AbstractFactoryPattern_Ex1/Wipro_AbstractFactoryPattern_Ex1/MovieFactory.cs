using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AbstractFactoryPattern_Ex1
{
    public class AnimationMovieFactory : IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodAnimation();
        }
        public IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodAnimation();
        }
    }
    public class ComedyMovieFactory : IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodComedy();
        }
        public IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodComedy();
        }
    }
    public class HorrorMovieFactory : IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodHorror();
        }
        public IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodHorror();
        }
    }
}
