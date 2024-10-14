using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TicketBackend.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Category1 { get; set; }
    [JsonIgnore]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
