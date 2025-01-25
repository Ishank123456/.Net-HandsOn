using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    public class AndroidTeam : IMobileTechnologiesTeamFactory
    {
        public string GetTeam()
        {
            return "Android Team will be working on this project";
        }
    }
}
