using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ISP_Ex1
{
    public class OracleDataClient : IOracleDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("Connection Opened Successfully");
            return 1;
        }
        public int CloseConnection()
        {
            Console.WriteLine("Connection Closed Successfully");
            return 1;
        }

        public int ExecuteOracleCommand()
        {
            Console.WriteLine("Oracle Command Executed Succesfully");
            return 1;
        }
    }
}
