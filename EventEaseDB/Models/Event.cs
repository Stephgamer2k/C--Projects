using System;
using System.Collections.Generic;

namespace EventEaseDB.Models;

public partial class Event
{
    public string EventId { get; set; } = null!;

    public string? EventName { get; set; }

    public string? EventDate { get; set; }

    public string? Description { get; set; }

    public string? VenueId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Venue? Venue { get; set; }
}
