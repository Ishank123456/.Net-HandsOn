using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserProfileRepository
    {
        UserProfile GetUserProfile(int id);
        void InsertUser(UserProfile userProfile);
        void UpdateUser(UserProfile userProfile);
    }
}
