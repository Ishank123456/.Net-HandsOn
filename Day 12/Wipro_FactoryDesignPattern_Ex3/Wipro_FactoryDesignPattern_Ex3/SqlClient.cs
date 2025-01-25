using System;

namespace Wipro_FactoryDesignPattern_Ex3
{
    public class SqlClient : IDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("Sql Connection Opened Succesfully");
            return 1;
        }
        public int CloseConnection()
        {
            Console.WriteLine("Sql Connection Closed Succesfully");
            return 1;
        }
    }
}
