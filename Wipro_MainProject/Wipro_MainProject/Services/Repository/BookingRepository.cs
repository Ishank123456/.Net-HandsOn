using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly WiproOnlineMovieBookingApplicationContext bookingDbContext;
        public BookingRepository(WiproOnlineMovieBookingApplicationContext _bookingDbContext)
        {
            bookingDbContext = _bookingDbContext;
        }

        public int AddBookingDetails(Booking booking)
        {
            bookingDbContext.Bookings.Add(booking);
            return bookingDbContext.SaveChanges();
        }

        public bool DeleteBookingDetails(int id)
        {
            var filterData = bookingDbContext.Bookings.SingleOrDefault(b => b.BookingId == id);
            var result = bookingDbContext.Bookings.Remove(filterData);
            bookingDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            //    var bookings = (from booking in bookingDbContext.Bookings
            //                    join user in bookingDbContext.Users on booking.UserId equals user.UserId
            //                    join movie in bookingDbContext.Movies on booking.MovieId equals movie.MovieId
            //                    select new Booking
            //                    {
            //                        BookingId = booking.BookingId,
            //                        UserId = booking.UserId,
            //                        UserName = booking.User.UserName, // Ensure UserName is in the User model
            //                        MovieId = booking.MovieId,
            //                        MovieName = booking.Movie.MovieName, // Access Movie.MovieName here
            //                        BookingDate = booking.BookingDate,
            //                        ShowTime = booking.ShowTime,
            //                        NumberOfTickets = booking.NumberOfTickets
            //                    }).ToList();

            //    return bookings;
            return bookingDbContext.Bookings.ToList();
        }


        public Booking GetBooking(int id)
        {
            return bookingDbContext.Bookings.SingleOrDefault(b => b.BookingId == id);
        }

        public int UpdateBookingDetails(Booking booking)
        {
            bookingDbContext.Bookings.Update(booking);
            return bookingDbContext.SaveChanges();
        }

        //public IEnumerable<Booking> GetAllBookingsByUserId(int userId)
        //{
        //    return bookingDbContext.Bookings
        //                   .Where(b => b.UserId == userId)
        //                   .ToList();
        //}
    }
}
