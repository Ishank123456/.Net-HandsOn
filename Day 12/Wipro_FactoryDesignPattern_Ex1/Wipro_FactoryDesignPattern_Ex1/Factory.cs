
namespace Wipro_FactoryDesignPattern_Ex1
{
    public class Factory
    {
        public IBase GetObject(int type)
        {
            IBase iBase = null;

            switch(type)
            {
                case 1:
                    iBase = new Derived1();
                    break;
                case 2:
                    iBase = new Derived2();
                    break;
            }
            return iBase;
        }
    }
}
