using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class KeHoachCoSo
{
    public long IdkeHoachCoSo { get; set; }

    public long? IdkeHoach { get; set; }

    public long? IdcoSo { get; set; }

    public DateTime? ThoiGianKiemTra { get; set; }

    public DateOnly? NgayTao { get; set; }

    public string? KetLuan { get; set; }

    public string? KhacPhuc { get; set; }

    public string? YkienChuCoSo { get; set; }

    public virtual ICollection<ChiTietKetQua> ChiTietKetQuas { get; set; } = new List<ChiTietKetQua>();

    public virtual CoSo? IdcoSoNavigation { get; set; }

    public virtual KeHoach? IdkeHoachNavigation { get; set; }
}
