using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

public partial class OrderService
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ServiceId { get; set; }

    public int? StatusId { get; set; }

    public virtual Order? Order { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderServiceDestroyer> OrderServiceDestroyers { get; set; } = new List<OrderServiceDestroyer>();

    public virtual Service? Service { get; set; }

    public virtual Status? Status { get; set; }
}
