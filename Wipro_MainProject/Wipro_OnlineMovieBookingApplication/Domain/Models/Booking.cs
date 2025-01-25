using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public int MovieId { get; set; }

    public string? MovieName { get; set; }

    public int MoviePrice { get; set; }

    public DateOnly BookingDate { get; set; }

    public string? ShowTime { get; set; }

    public int NumberOfTickets { get; set; }

    public virtual Movie? Movie { get; set; }

    public virtual User? User { get; set; }
}
