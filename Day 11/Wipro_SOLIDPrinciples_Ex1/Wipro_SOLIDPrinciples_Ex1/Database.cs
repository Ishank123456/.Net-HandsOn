using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SOLIDPrinciples_Ex1
{
    public class Database : IDataChannel, IConnection
    {
        public void Send(char c)
        {
            Console.WriteLine($"Sending: {c}");
        }
        public char Recv()
        {
            return 'R';
        }
        public void Dial(string phn)
        {
            Console.WriteLine($"Dialing: {phn}");
        }
        public char HangUp()
        {
            return 'H';
        }
    }
}
