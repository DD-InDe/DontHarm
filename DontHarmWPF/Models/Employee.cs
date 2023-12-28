using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Login { get; set; }

    public string? Pas { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? LastEnter { get; set; }

    public string? TextServices { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<LoginHistory> LoginHistories { get; set; } = new List<LoginHistory>();

    public virtual ICollection<OrderServiceDestroyer> OrderServiceDestroyers { get; set; } = new List<OrderServiceDestroyer>();

    public virtual Role? Role { get; set; }
}
