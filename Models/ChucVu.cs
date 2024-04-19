using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class ChucVu
{
    public long IdchucVu { get; set; }

    public string? TenChucVu { get; set; }

    public virtual ICollection<CanBo> CanBos { get; set; } = new List<CanBo>();
}
