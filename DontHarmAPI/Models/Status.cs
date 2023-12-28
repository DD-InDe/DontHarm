using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

public partial class Status
{
    public int Id { get; set; }

    public string? Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();
    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
