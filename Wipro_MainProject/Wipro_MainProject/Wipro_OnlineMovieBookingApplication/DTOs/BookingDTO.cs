namespace Wipro_OnlineMovieBookingApplication.DTOs
{
    public class BookingDTO
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MoviePrice { get; set; }
        public DateOnly BookingDate { get; set; }
        public string ShowTime { get; set; }
        public int NumberOfTickets { get; set; }
        public int TotalPrice { get; set; }
    }
}
