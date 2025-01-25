using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    public class DotNetTeam : IDotNetTeamFactory
    {
        public string GetTeam()
        {
            return "Dot Net Team will be working on this project";
        }
    }
}
