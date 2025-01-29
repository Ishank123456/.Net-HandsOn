using System.ComponentModel.DataAnnotations;

namespace Wipro_OnlineMovieBookingApplication.ViewModels
{
    public class AddBookingViewModel
    {
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Display(Name = "Movie Name")]
        public int MovieId { get; set; }
        public int MoviePrice { get; set; }
        public DateOnly BookingDate { get; set; }
        public string? ShowTime { get; set; }
        public int NumberOfTickets { get; set; }
        //public double TotalPrice { get; set; }
    }
}
