
namespace Wipro_Practice_dll
{
    public class Connection : IConnection
    {
        public string OpenConnection()
        {
            return "Connection Opened";
        }
        public string CloseConnection()
        {
            return "Connection Closed";
        }
    }
}
