
namespace Wipro_FactoryDesignPattern_Ex2
{
    public class Factory
    {
        public IIceCream GetObjects(int type)
        {
            IIceCream objIceCream = null;

            switch(type)
            {
                case 1:
                    objIceCream = new Strawberry();
                    break;
                case 2:
                    objIceCream = new Chocolate();
                    break;
                case 3:
                    objIceCream = new Vanilla();
                    break;
            }
            return objIceCream;
        }
    }
}
