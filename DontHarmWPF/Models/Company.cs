using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? Address { get; set; }

    public long? Inn { get; set; }

    public string? IpAddress { get; set; }

    public long? InPc { get; set; }

    public long? InBik { get; set; }

    public string? Ua { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
