using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DesignPattern_Ex1
{
    public class ProjectTeamsFactory : IBaseFactory
    {
        private SkillSets skillDotNetType;
        private SkillSets skillMobileType;
        public ProjectTeamsFactory(SkillSets _skillDotNetType, SkillSets _skillMobileType)
        {
            skillDotNetType = _skillDotNetType;
            skillMobileType = _skillMobileType;
        }

        public IDotNetTeamFactory GetDotNetTeam()
        {
            switch(skillDotNetType)
            {
                case SkillSets.DotNet:
                    return new DotNetTeam();
                case SkillSets.SliverLight:
                    return new SliverLightTeam();
            }
            return null;
        }
        public IMobileTechnologiesTeamFactory GetMobileTechnologiesTeam()
        {
            switch (skillMobileType)
            {
                case SkillSets.Android:
                    return new AndroidTeam();
                case SkillSets.IOS:
                    return new IOSTeam();
            }
            return null;
        }
    }
}
