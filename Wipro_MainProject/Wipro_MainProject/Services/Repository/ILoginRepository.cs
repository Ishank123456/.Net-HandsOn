using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public interface ILoginRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}

