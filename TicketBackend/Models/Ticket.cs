using System;
using System.Collections.Generic;

namespace TicketBackend.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string? Problem { get; set; }

    public string? Resolution { get; set; }

    public bool? Completed { get; set; }

    public string? Priority { get; set; }

    public string? AuthorId { get; set; }

    public string? ResolverId { get; set; }

    public DateTime? Date { get; set; }

    public int? CategoryId { get; set; }

    public virtual User? Author { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual User? Resolver { get; set; }
}
