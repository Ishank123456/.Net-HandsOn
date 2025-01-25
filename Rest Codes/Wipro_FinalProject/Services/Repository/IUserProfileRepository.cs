using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_FinalProject.Models;

namespace Services.Repository
{
    public interface IUserProfileRepository
    {
        UserProfile GetUserProfile(long id);
    }
}
