using Domain.DAL;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly Wipro29082024Context userProfileDbContext;
        public UserProfileRepository(Wipro29082024Context _userProfileDbContext)
        {
            userProfileDbContext = _userProfileDbContext;
        }

        public UserProfile GetUserProfile(int id)
        {
            return userProfileDbContext.UserProfiles.FirstOrDefault(u => u.UserProfileId == id);
        }

        public void InsertUser(UserProfile userProfile)
        {
            userProfileDbContext.UserProfiles.Add(userProfile);
            userProfileDbContext.SaveChanges();
        }

        public void UpdateUser(UserProfile userProfile)
        {
            userProfileDbContext.UserProfiles.Update(userProfile);
            userProfileDbContext.SaveChanges();
        }
    }
}
