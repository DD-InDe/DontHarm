using System;
using System.Collections.Generic;

namespace DontHarmAPI.Models;

public partial class LoginHistory
{
    public int Id { get; set; }

    public DateTime? LogDate { get; set; }

    public bool? Successfully { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
