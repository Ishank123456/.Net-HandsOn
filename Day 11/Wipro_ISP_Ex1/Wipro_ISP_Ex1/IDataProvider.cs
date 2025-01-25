using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ISP_Ex1
{
    public interface IDataProvider
    {
        int OpenConnection();
        int CloseConnection();
    }
    public interface ISqlDataProvider : IDataProvider
    {
        int ExecuteSqlCommand();
    }
    public interface IOracleDataProvider : IDataProvider
    {
        int ExecuteOracleCommand();
    }
}
