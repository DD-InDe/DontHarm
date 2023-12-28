using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DontHarmAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? FinishDays { get; set; }

    public int? StatusId { get; set; }

    public bool? Deleted { get; set; }
    [JsonIgnore]
    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public virtual Status? Status { get; set; }
}
