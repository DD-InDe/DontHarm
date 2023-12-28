﻿using System;
using System.Collections.Generic;

namespace DontHarmWPF.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? FinishDays { get; set; }

    public int? StatusId { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public virtual Status? Status { get; set; }
}
