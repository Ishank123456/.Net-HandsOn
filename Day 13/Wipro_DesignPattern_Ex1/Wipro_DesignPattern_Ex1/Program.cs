using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================Team 1====================================");
            ProjectTeamsFactory objFactory1 = new ProjectTeamsFactory(SkillSets.DotNet, SkillSets.Android);
            IDotNetTeamFactory objDotNetTeam1 = objFactory1.GetDotNetTeam();
            IMobileTechnologiesTeamFactory objMobileTeam1 = objFactory1.GetMobileTechnologiesTeam();
            Console.WriteLine(objDotNetTeam1.GetTeam());
            Console.WriteLine(objMobileTeam1.GetTeam());
            Console.WriteLine();

            Console.WriteLine("====================================Team 2====================================");
            ProjectTeamsFactory objFactory2 = new ProjectTeamsFactory(SkillSets.SliverLight, SkillSets.IOS);
            IDotNetTeamFactory objDotNetTeam2 = objFactory2.GetDotNetTeam();
            IMobileTechnologiesTeamFactory objMobileTeam2 = objFactory2.GetMobileTechnologiesTeam();
            Console.WriteLine(objDotNetTeam2.GetTeam());
            Console.WriteLine(objMobileTeam2.GetTeam());

            Console.ReadLine();
        }
    }
}
