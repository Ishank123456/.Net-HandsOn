using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SOLIDPrinciples_Ex1
{
    public interface IDataChannel
    {
        void Send(char c);
        char Recv();
    }

    public interface IConnection
    {
        void Dial(string phn);
        char HangUp();
    }
}
