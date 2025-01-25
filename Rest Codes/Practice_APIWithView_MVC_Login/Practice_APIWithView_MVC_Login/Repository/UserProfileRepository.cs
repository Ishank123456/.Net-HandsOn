using Practice_APIWithView_MVC_Login.DTOs;
using Practice_APIWithView_MVC_Login.EntityFramework;
using Practice_APIWithView_MVC_Login.Models;

namespace Practice_APIWithView_MVC_Login.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly UserDbContext userDbContext;
        public UserProfileRepository(UserDbContext _userDbContext)
        {
            userDbContext = _userDbContext;
        }

        public IEnumerable<UserProfile> GetAllProfiles()
        {
            return userDbContext.Profiles.ToList();
        }

        public UserProfile GetProfile(int id)
        {
            return userDbContext.Profiles.SingleOrDefault(u => u.UserId == id);
        }

        public int RegisterUserProfile(UserProfile profile)
        {
            userDbContext.Profiles.Add(profile);
            return userDbContext.SaveChanges();
        }
    }
}
