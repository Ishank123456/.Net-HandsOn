using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    public interface IDotNetTeamFactory
    {
        string GetTeam();
    }
    public enum SkillSets
    {
        SliverLight, DotNet, Android, IOS
    }
}
