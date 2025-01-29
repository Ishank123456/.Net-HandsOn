using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
        Booking GetBooking(int id);
        int AddBookingDetails(Booking booking);
        int UpdateBookingDetails(Booking booking);
        bool DeleteBookingDetails(int id);
      //  IEnumerable<Booking> GetAllBookingsByUserId(int userId);
    }
}
