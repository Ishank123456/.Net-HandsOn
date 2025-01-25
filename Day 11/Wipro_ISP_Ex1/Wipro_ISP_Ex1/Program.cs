using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ISP_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================SQL===========================");
            SqlDataClient objSqlDataClient = new SqlDataClient();
            objSqlDataClient.OpenConnection();
            objSqlDataClient.ExecuteSqlCommand();
            objSqlDataClient.CloseConnection();
            Console.WriteLine();

            Console.WriteLine("===========================Oracle===========================");
            OracleDataClient objOracleDataClient = new OracleDataClient();
            objOracleDataClient.OpenConnection();
            objOracleDataClient.ExecuteOracleCommand();
            objOracleDataClient.CloseConnection();

            Console.ReadLine();
        }
    }
}
