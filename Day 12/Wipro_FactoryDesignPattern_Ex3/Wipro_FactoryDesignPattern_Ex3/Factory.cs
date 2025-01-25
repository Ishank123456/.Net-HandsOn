

namespace Wipro_FactoryDesignPattern_Ex3
{
    public class Factory
    {
        public IDataProvider GetProvider(int type)
        {
            IDataProvider objIDataProvider = null;

            switch(type)
            {
                case 1:
                    objIDataProvider = new SqlClient();
                    break;
                case 2:
                    objIDataProvider = new OracleClient();
                    break;
                case 3:
                    objIDataProvider = new MSAccessClient();
                    break;
            }
            return objIDataProvider;
        }
    }
}
