using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class TinTuc
{
    public long IdtinTuc { get; set; }

    public string? TieuDe { get; set; }

    public string? NoiDung { get; set; }

    public DateOnly? NgayDang { get; set; }

    public long? IdcanBo { get; set; }

    public virtual CanBo? IdcanBoNavigation { get; set; }
}
