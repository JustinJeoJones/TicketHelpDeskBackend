using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TicketBackend.Models;

public partial class Comment
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public string? AuthorId { get; set; }

    public string? Message { get; set; }

    public DateTime? Date { get; set; }

    public virtual User? Author { get; set; }

    [JsonIgnore]
    public virtual Ticket? Ticket { get; set; }
}
