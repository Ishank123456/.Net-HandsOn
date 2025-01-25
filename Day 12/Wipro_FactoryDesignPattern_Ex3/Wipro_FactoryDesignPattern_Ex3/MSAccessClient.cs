using System;

namespace Wipro_FactoryDesignPattern_Ex3
{
    public class MSAccessClient : IDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("MSAccess Connection Opened Succesfully");
            return 1;
        }
        public int CloseConnection()
        {
            Console.WriteLine("MSAccess Connection Closed Succesfully");
            return 1;
        }
    }
}
