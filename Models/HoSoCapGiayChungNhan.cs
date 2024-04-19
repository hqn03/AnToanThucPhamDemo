using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class HoSoCapGiayChungNhan
{
    public long IdgiayChungNhan { get; set; }

    public long? IdcoSo { get; set; }

    public DateOnly? NgayDangKy { get; set; }

    public string? LoaiThucPham { get; set; }

    public string? HinhAnhMinhChung { get; set; }

    public int? TrangThai { get; set; }

    public virtual CoSo? IdcoSoNavigation { get; set; }
}
