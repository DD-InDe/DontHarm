using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

public partial class SocialType
{
    public int Id { get; set; }

    public string? Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
