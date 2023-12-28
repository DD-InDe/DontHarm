using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class OrderService
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ServiceId { get; set; }

    public int? StatusId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ICollection<OrderServiceDestroyer> OrderServiceDestroyers { get; set; } = new List<OrderServiceDestroyer>();

    public virtual Service? Service { get; set; }

    public virtual Status? Status { get; set; }
}
