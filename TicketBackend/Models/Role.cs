using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TicketBackend.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    [JsonIgnore]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
