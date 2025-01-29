using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WiproOnlineMovieBookingApplicationContext userDbContext;

        public UserRepository(WiproOnlineMovieBookingApplicationContext _userDbContext)
        {
            userDbContext = _userDbContext;
        }

        // Add User
        public int AddUser(User user)
        {
            userDbContext.Users.Add(user);
            return userDbContext.SaveChanges();
        }

        // Delete User
        public bool DeleteUser(int id)
        {
            var filterData = userDbContext.Users.SingleOrDefault(u => u.UserId == id);
            var result = userDbContext.Users.Remove(filterData);
            userDbContext.SaveChanges();
            return result != null;
        }

        // Get All Users
        public IEnumerable<User> GetAllUsers()
        {
            return userDbContext.Users.ToList();
        }

        // Get User by ID
        public User GetUser(int id)
        {
            return userDbContext.Users.SingleOrDefault(u => u.UserId == id);
        }

        // Update User
        public int UpdateUser(User user)
        {
            userDbContext.Users.Update(user);
            return userDbContext.SaveChanges();
        }

        // Check if User exists
        public bool UserExists(int userId)
        {
            return userDbContext.Users.Any(u => u.UserId == userId);
        }
    }
}
