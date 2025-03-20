using System;
using System.Collections.Generic;

namespace EventEaseDB.Models;

public partial class Venue
{
    public string VenueId { get; set; } = null!;

    public string? VenueName { get; set; }

    public string? Location { get; set; }

    public string? Capacity { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
