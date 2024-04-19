using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class ChuCoSo
{
    public long IdchuCoSo { get; set; }

    public string? HoTen { get; set; }

    public string? Cccd { get; set; }

    public string? Sdt { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<CoSo> CoSos { get; set; } = new List<CoSo>();

    public virtual ICollection<ThongBaoThayDoi> ThongBaoThayDois { get; set; } = new List<ThongBaoThayDoi>();
}
