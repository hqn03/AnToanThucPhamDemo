using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class BanCongBoSp
{
    public long IdbanCongBoSp { get; set; }

    public long? IdcoSo { get; set; }

    public DateOnly? NgayCongBo { get; set; }

    public string? TenSanPham { get; set; }

    public string? ThanhPhan { get; set; }

    public DateOnly? ThoiHanSuDung { get; set; }

    public string? CachDongGoiBaoBi { get; set; }

    public string? TenDiaChiSx { get; set; }

    public string? MauNhanSp { get; set; }

    public string? HinhAnhMinhChung { get; set; }

    public int? TrangThai { get; set; }

    public virtual CoSo? IdcoSoNavigation { get; set; }
}
