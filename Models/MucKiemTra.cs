using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class MucKiemTra
{
    public long IdmucKt { get; set; }

    public string? NoiDung { get; set; }

    public virtual ICollection<ChiTietKetQua> ChiTietKetQuas { get; set; } = new List<ChiTietKetQua>();
}
