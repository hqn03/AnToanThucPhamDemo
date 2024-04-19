using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class CanBo
{
    public long IdcanBo { get; set; }

    public string? HoTen { get; set; }

    public string? Cccd { get; set; }

    public string? MatKhau { get; set; }

    public long? IdchucVu { get; set; }

    public virtual ICollection<ChiTietDoanThanhTra> ChiTietDoanThanhTras { get; set; } = new List<ChiTietDoanThanhTra>();

    public virtual ChucVu? IdchucVuNavigation { get; set; }

    public virtual ICollection<TinTuc> TinTucs { get; set; } = new List<TinTuc>();
}
