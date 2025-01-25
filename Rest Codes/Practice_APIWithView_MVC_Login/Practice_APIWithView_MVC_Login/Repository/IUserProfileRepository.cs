using Practice_APIWithView_MVC_Login.DTOs;
using Practice_APIWithView_MVC_Login.Models;

namespace Practice_APIWithView_MVC_Login.Repository
{
    public interface IUserProfileRepository
    {
        IEnumerable<UserProfile> GetAllProfiles();
        UserProfile GetProfile(int id);
        int RegisterUserProfile(UserProfile profile);
    }
}
