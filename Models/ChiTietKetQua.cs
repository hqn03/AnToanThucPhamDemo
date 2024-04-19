using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class ChiTietKetQua
{
    public long IdkeHoachCoSo { get; set; }

    public long IdmucKt { get; set; }

    public bool? Dat { get; set; }

    public virtual KeHoachCoSo IdkeHoachCoSoNavigation { get; set; } = null!;

    public virtual MucKiemTra IdmucKtNavigation { get; set; } = null!;
}
