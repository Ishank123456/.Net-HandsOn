

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public class AnimationMovieFactory : IMovieFactory
    {
        public override IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodAnimation();
        }
        public override IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodAnimation();
        }
    }

    

    
}
