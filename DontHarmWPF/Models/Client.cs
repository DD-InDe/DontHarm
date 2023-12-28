using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class Client
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Login { get; set; }

    public string? Pas { get; set; }

    public string? Email { get; set; }

    public long? SocialSecNumber { get; set; }

    public string? Ein { get; set; }

    public string? Phone { get; set; }

    public long? PassS { get; set; }

    public long? PassN { get; set; }

    public string? Birthday { get; set; }

    public int? SocialTypeId { get; set; }

    public int? CompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual SocialType? SocialType { get; set; }
}
