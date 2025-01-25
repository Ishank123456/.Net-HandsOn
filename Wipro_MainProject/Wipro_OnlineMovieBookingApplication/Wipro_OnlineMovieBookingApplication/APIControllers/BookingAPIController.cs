using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnlineMovieBookingApplication.DTOs;
using Wipro_OnlineMovieBookingApplication.ViewModels;

namespace Wipro_OnlineMovieBookingApplication.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingAPIController : ControllerBase
    {
        private readonly IBookingRepository iBookingRepository;
        private readonly IUserRepository iUserRepository;
        private readonly IMovieRepository iMovieRepository;
        private readonly OnlineMovieBookingApplicationContext context;
        public BookingAPIController(IBookingRepository _iBookingRepository, 
            IUserRepository _iUserRepository, IMovieRepository _iMovieRepository,
            OnlineMovieBookingApplicationContext _context)
        {
            iBookingRepository = _iBookingRepository;
            iUserRepository = _iUserRepository;
            iMovieRepository = _iMovieRepository;
            context = _context;
        }

        [HttpGet("GetAllBookings")]
        public ActionResult GetAllBookings()
        {
            return Ok(iBookingRepository.GetAllBookings());

            //var bookings = (from booking in context.Bookings
            //                join user in context.Users on booking.UserId equals user.UserId
            //                join movie in context.Movies on booking.MovieId equals movie.MovieId
            //                select new BookingDTO
            //                {
            //                    BookingId = booking.BookingId,
            //                    UserId = booking.UserId,
            //                    UserName = user.UserName,
            //                    MovieId = booking.MovieId,
            //                    MovieName = movie.MovieName,
            //                    BookingDate = booking.BookingDate,
            //                    ShowTime = booking.ShowTime,
            //                    NumberOfTickets = booking.NumberOfTickets
            //                }).ToList();

            //return Ok(bookings);


            //List<BookingDTO> lstBooking = new List<BookingDTO>();

            //iBookingRepository.GetAllBookings().ToList().ForEach(b =>
            //{
            //    BookingDTO bookingDTO = new BookingDTO()
            //    {
            //        UserId = b.UserId,
            //        MovieId = b.MovieId,
            //        MoviePrice = b.MoviePrice,
            //        BookingId = b.BookingId,
            //        BookingDate = b.BookingDate,
            //        ShowTime = b.ShowTime,
            //        NumberOfTickets = b.NumberOfTickets,
            //        //TotalPrice = b.TotalPrice,
            //    };
            //    lstBooking.Add(bookingDTO);
            //});
            //return Ok(lstBooking);
        }

        [HttpGet("GetBookingById")]
        public ActionResult GetBookingById(int bookingId)
        {
            BookingDTO bookingDTO = new BookingDTO();
            Booking bookingEntity = iBookingRepository.GetBooking(bookingId);
            bookingDTO.BookingId = bookingEntity.BookingId;
            bookingDTO.UserId = bookingEntity.UserId;
            bookingDTO.MovieId = bookingEntity.MovieId;
            bookingDTO.BookingDate = bookingEntity.BookingDate;
            bookingDTO.ShowTime = bookingEntity.ShowTime;
            bookingDTO.NumberOfTickets = bookingEntity.NumberOfTickets;
            //bookingDTO.TotalPrice = bookingEntity.TotalPrice;

            return Ok(bookingDTO);
        }

        [HttpPost("AddBooking")]
        public ActionResult AddBooking(BookingDTOCreate bookingModel)
        {
            Booking bookingEntity = new Booking()
            {
                UserId = bookingModel.UserId,
                MovieId = bookingModel.MovieId,
                MoviePrice = bookingModel.MoviePrice,
                BookingDate = bookingModel.BookingDate,
                ShowTime = bookingModel.ShowTime,
                NumberOfTickets = bookingModel.NumberOfTickets,
                //TotalPrice = bookingModel.TotalPrice,

            };
            iBookingRepository.AddBookingDetails(bookingEntity);
            return Ok(bookingEntity);
        }

        [HttpPut("EditBooking")]
        public ActionResult EditBooking(BookingDTO bookingModel)
        {
            Booking bookingEntity = new Booking()
            {
                BookingDate = bookingModel.BookingDate,
                NumberOfTickets = bookingModel.NumberOfTickets,
                //TotalPrice = bookingModel.TotalPrice
            };
            iBookingRepository.UpdateBookingDetails(bookingEntity);
            return Ok(bookingEntity);
        }

        [HttpDelete("DeleteBooking")]
        public ActionResult DeleteBooking(int bookingId)
        {
            return Ok(iBookingRepository.DeleteBookingDetails(bookingId));
        }

        [HttpGet("GetAllBookingForUser")]
        public ActionResult<IEnumerable<BookingDTO>> GetAllBookingsForUser(int userId)
        {
            var bookings = iBookingRepository.GetAllBookingsByUserId(userId);

            if (bookings == null || !bookings.Any())
            {
                return NotFound("No bookings found for the specified user.");
            }

            var bookingDTOs = bookings.Select(b => new BookingDTO
            {
                BookingId = b.BookingId,
                UserId = b.UserId,
                MovieId = b.MovieId,
                BookingDate = b.BookingDate,
                ShowTime = b.ShowTime,
                NumberOfTickets = b.NumberOfTickets
            }).ToList();

            return Ok(bookingDTOs);
        }

    }
}
