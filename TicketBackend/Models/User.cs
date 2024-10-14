using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TicketBackend.Models;

public partial class User
{
    public string GoogleId { get; set; } = null!;

    public string? Username { get; set; }

    public string? Pfp { get; set; }

    public int? RoleId { get; set; }

    [JsonIgnore]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    [JsonIgnore]
    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual Role? Role { get; set; }
    [JsonIgnore]
    public virtual ICollection<Ticket> TicketAuthors { get; set; } = new List<Ticket>();
    [JsonIgnore]
    public virtual ICollection<Ticket> TicketResolvers { get; set; } = new List<Ticket>();
}
