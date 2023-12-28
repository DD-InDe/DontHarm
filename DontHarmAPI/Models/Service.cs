using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Cost { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();
}
