using System;
using System.Collections.Generic;

namespace DontHarmAPI.Models;

public partial class OrderServiceDestroyer
{
    public int OrderServiceDestroyerId { get; set; }

    public int? EmployeeId { get; set; }

    public int? OrderServiceId { get; set; }

    public decimal? AfterDestroy { get; set; }

    public double? Disp { get; set; }

    public double? ConcR { get; set; }

    public double? ConC { get; set; }

    public double? ConK { get; set; }

    public double? ConMe { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual OrderService? OrderService { get; set; }
}
