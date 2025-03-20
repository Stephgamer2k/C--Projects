using System;
using System.Collections.Generic;

namespace EventEaseDB.Models;

public partial class Booking
{
    public string BookingId { get; set; } = null!;

    public string? EventId { get; set; }

    public string? VenueId { get; set; }

    public string? BookingDate { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Venue? Venue { get; set; }
}
