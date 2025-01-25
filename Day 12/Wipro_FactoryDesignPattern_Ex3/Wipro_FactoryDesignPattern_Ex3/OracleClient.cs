using System;

namespace Wipro_FactoryDesignPattern_Ex3
{
    public class OracleClient : IDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("Oracle Connection Opened Succesfully");
            return 1;
        }
        public int CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed Succesfully");
            return 1;
        }
    }
}
