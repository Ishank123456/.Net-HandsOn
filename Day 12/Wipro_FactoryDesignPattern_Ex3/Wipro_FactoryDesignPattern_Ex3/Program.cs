using System;

namespace Wipro_FactoryDesignPattern_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new Factory();

            IDataProvider objDataProvider1 = objFactory.GetProvider(1);
            objDataProvider1.OpenConnection();
            objDataProvider1.CloseConnection();
            Console.WriteLine();

            IDataProvider objDataProvider2 = objFactory.GetProvider(2);
            objDataProvider2.OpenConnection();
            objDataProvider2.CloseConnection();
            Console.WriteLine();

            IDataProvider objDataProvider3 = objFactory.GetProvider(3);
            objDataProvider3.OpenConnection();
            objDataProvider3.CloseConnection();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
