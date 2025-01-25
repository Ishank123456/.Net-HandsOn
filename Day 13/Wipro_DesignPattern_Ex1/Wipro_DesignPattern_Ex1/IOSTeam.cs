using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    public class IOSTeam : IMobileTechnologiesTeamFactory
    {
        public string GetTeam()
        {
            return "IOS Team will be working on this project";
        }
    }
}
