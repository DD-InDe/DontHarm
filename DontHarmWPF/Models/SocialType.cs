using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class SocialType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
