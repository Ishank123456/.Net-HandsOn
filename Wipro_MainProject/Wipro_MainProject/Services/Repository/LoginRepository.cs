using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly WiproOnlineMovieBookingApplicationContext userLoginDbContext;

        public LoginRepository(WiproOnlineMovieBookingApplicationContext _userLoginDbContext)
        {
            userLoginDbContext = _userLoginDbContext;
        }

        // Correct implementation of the GetAllUsers method
        public IEnumerable<User> GetAllUsers()
        {
            return userLoginDbContext.Users.ToList();
        }
    }
}
