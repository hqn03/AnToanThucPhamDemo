﻿using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class CoSo
{
    public long IdcoSo { get; set; }

    public long? IdchuCoSo { get; set; }

    public string? TenCoSo { get; set; }

    public string? DiaChi { get; set; }

    public string? LoaiHinhKinhDoanh { get; set; }

    public string? SoGiayPhepKd { get; set; }

    public DateOnly? NgayCapGiayPhepKd { get; set; }

    public DateOnly? NgayCapCnattp { get; set; }

    public DateOnly? NgayHetHanCnattp { get; set; }

    public virtual ICollection<BanCongBoSp> BanCongBoSps { get; set; } = new List<BanCongBoSp>();

    public virtual ICollection<BaoCaoViPham> BaoCaoViPhams { get; set; } = new List<BaoCaoViPham>();

    public virtual ICollection<HoSoCapGiayChungNhan> HoSoCapGiayChungNhans { get; set; } = new List<HoSoCapGiayChungNhan>();

    public virtual ChuCoSo? IdchuCoSoNavigation { get; set; }

    public virtual ICollection<KeHoachCoSo> KeHoachCoSos { get; set; } = new List<KeHoachCoSo>();

    public virtual ICollection<ThongBaoThayDoi> ThongBaoThayDois { get; set; } = new List<ThongBaoThayDoi>();
}
