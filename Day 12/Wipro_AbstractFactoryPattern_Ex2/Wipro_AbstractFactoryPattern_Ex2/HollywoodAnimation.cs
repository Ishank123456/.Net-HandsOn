

namespace Wipro_AbstractFactoryPattern_Ex2
{
    public class HollywoodAnimation : IHollywoodMovie
    {
        public override string MovieName
        {
            get 
            { 
                return "Kung Fu Panda"; 
            } 
        }
    }
}
