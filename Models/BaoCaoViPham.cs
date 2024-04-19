using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class BaoCaoViPham
{
    public long IdbaoCao { get; set; }

    public string? HoTen { get; set; }

    public string? Sdt { get; set; }

    public string? Cccd { get; set; }

    public DateOnly? NgayBaoCao { get; set; }

    public string? HinhAnhMinhChung { get; set; }

    public long? IdcoSo { get; set; }

    public virtual CoSo? IdcoSoNavigation { get; set; }
}
