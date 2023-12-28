using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

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

    [JsonIgnore] public virtual ICollection<LoginHistory> LoginHistories { get; set; } = new List<LoginHistory>();
    [JsonIgnore] public virtual ICollection<OrderServiceDestroyer> OrderServiceDestroyers { get; set; } = new List<OrderServiceDestroyer>();

    public virtual Role? Role { get; set; }
}