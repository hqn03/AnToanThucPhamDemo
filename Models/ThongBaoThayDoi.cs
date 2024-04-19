using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class ThongBaoThayDoi
{
    public long IdthongBao { get; set; }

    public long? IdcoSo { get; set; }

    public long? IdchuCoSoMoi { get; set; }

    public string? TenCoSoMoi { get; set; }

    public string? DiaChiMoi { get; set; }

    public int? TrangThai { get; set; }

    public virtual ChuCoSo? IdchuCoSoMoiNavigation { get; set; }

    public virtual CoSo? IdcoSoNavigation { get; set; }
}
