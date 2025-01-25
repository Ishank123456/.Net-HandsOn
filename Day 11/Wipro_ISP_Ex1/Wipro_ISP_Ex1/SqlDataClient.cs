using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ISP_Ex1
{
    public class SqlDataClient : ISqlDataProvider
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
        public int ExecuteSqlCommand()
        {
            Console.WriteLine("SQL Command Executed Succesfully");
            return 1;
        }

    }
}
