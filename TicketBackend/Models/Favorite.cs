using System;
using System.Collections.Generic;

namespace TicketBackend.Models;

public partial class Favorite
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public string? UserId { get; set; }

    public virtual Ticket? Ticket { get; set; }

    public virtual User? User { get; set; }
}
