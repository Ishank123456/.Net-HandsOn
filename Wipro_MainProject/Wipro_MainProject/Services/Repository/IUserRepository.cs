using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        int AddUser(User user);
        int UpdateUser(User user);
        bool DeleteUser(int id);
        bool UserExists(int userId);
    }
}
