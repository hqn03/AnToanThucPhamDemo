using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class ChiTietDoanThanhTra
{
    public long IdkeHoach { get; set; }

    public long IdcanBo { get; set; }

    public string? ChucVu { get; set; }

    public virtual CanBo IdcanBoNavigation { get; set; } = null!;

    public virtual KeHoach IdkeHoachNavigation { get; set; } = null!;
}
