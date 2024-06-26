﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models;

public partial class QlattpContext : DbContext
{
    public QlattpContext()
    {
    }

    public QlattpContext(DbContextOptions<QlattpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BanCongBoSp> BanCongBoSps { get; set; }

    public virtual DbSet<BaoCaoViPham> BaoCaoViPhams { get; set; }

    public virtual DbSet<CanBo> CanBos { get; set; }

    public virtual DbSet<ChiTietDoanThanhTra> ChiTietDoanThanhTras { get; set; }

    public virtual DbSet<ChiTietKetQua> ChiTietKetQuas { get; set; }

    public virtual DbSet<ChuCoSo> ChuCoSos { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<CoSo> CoSos { get; set; }

    public virtual DbSet<HoSoCapGiayChungNhan> HoSoCapGiayChungNhans { get; set; }

    public virtual DbSet<KeHoach> KeHoaches { get; set; }

    public virtual DbSet<KeHoachCoSo> KeHoachCoSos { get; set; }

    public virtual DbSet<MucKiemTra> MucKiemTras { get; set; }

    public virtual DbSet<ThongBaoThayDoi> ThongBaoThayDois { get; set; }

    public virtual DbSet<TinTuc> TinTucs { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QLATTP;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BanCongBoSp>(entity =>
        {
            entity.HasKey(e => e.IdbanCongBoSp).HasName("PK__BanCongB__578244189DB13F47");

            entity.ToTable("BanCongBoSP");

            entity.Property(e => e.IdbanCongBoSp).HasColumnName("IDBanCongBoSP");
            entity.Property(e => e.CachDongGoiBaoBi)
                .HasMaxLength(200)
                .HasColumnName("CachDongGoi_BaoBi");
            entity.Property(e => e.HinhAnhMinhChung)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.MauNhanSp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MauNhanSP");
            entity.Property(e => e.TenDiaChiSx)
                .HasMaxLength(200)
                .HasColumnName("Ten_DiaChiSX");
            entity.Property(e => e.TenSanPham).HasMaxLength(100);
            entity.Property(e => e.ThanhPhan).HasMaxLength(100);

            entity.HasOne(d => d.IdcoSoNavigation).WithMany(p => p.BanCongBoSps)
                .HasForeignKey(d => d.IdcoSo)
                .HasConstraintName("FK__BanCongBo__IDCoS__440B1D61");
        });

        modelBuilder.Entity<BaoCaoViPham>(entity =>
        {
            entity.HasKey(e => e.IdbaoCao).HasName("PK__BaoCaoVi__BC216EF04141262E");

            entity.ToTable("BaoCaoViPham");

            entity.Property(e => e.IdbaoCao).HasColumnName("IDBaoCao");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.HinhAnhMinhChung)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");

            entity.HasOne(d => d.IdcoSoNavigation).WithMany(p => p.BaoCaoViPhams)
                .HasForeignKey(d => d.IdcoSo)
                .HasConstraintName("FK__BaoCaoViP__IDCoS__4AB81AF0");
        });

        modelBuilder.Entity<CanBo>(entity =>
        {
            entity.HasKey(e => e.IdcanBo).HasName("PK__CanBo__D8C385ACD9B7FD48");

            entity.ToTable("CanBo");

            entity.Property(e => e.IdcanBo).HasColumnName("IDCanBo");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .HasColumnName("CCCD");
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.IdchucVu).HasColumnName("IDChucVu");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdchucVuNavigation).WithMany(p => p.CanBos)
                .HasForeignKey(d => d.IdchucVu)
                .HasConstraintName("FK__CanBo__IDChucVu__398D8EEE");
        });

        modelBuilder.Entity<ChiTietDoanThanhTra>(entity =>
        {
            entity.HasKey(e => new { e.IdkeHoach, e.IdcanBo }).HasName("PK__ChiTietD__4EE329927091E271");

            entity.ToTable("ChiTietDoanThanhTra");

            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.IdcanBo).HasColumnName("IDCanBo");
            entity.Property(e => e.ChucVu).HasMaxLength(50);

            entity.HasOne(d => d.IdcanBoNavigation).WithMany(p => p.ChiTietDoanThanhTras)
                .HasForeignKey(d => d.IdcanBo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__IDCan__534D60F1");

            entity.HasOne(d => d.IdkeHoachNavigation).WithMany(p => p.ChiTietDoanThanhTras)
                .HasForeignKey(d => d.IdkeHoach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__IDKeH__52593CB8");
        });

        modelBuilder.Entity<ChiTietKetQua>(entity =>
        {
            entity.HasKey(e => new { e.IdkeHoachCoSo, e.IdmucKt }).HasName("PK__ChiTietK__E62BAC5966089926");

            entity.ToTable("ChiTietKetQua");

            entity.Property(e => e.IdkeHoachCoSo).HasColumnName("IDKeHoachCoSo");
            entity.Property(e => e.IdmucKt).HasColumnName("IDMucKT");

            entity.HasOne(d => d.IdkeHoachCoSoNavigation).WithMany(p => p.ChiTietKetQuas)
                .HasForeignKey(d => d.IdkeHoachCoSo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietKe__IDKeH__5BE2A6F2");

            entity.HasOne(d => d.IdmucKtNavigation).WithMany(p => p.ChiTietKetQuas)
                .HasForeignKey(d => d.IdmucKt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietKe__IDMuc__5CD6CB2B");
        });

        modelBuilder.Entity<ChuCoSo>(entity =>
        {
            entity.HasKey(e => e.IdchuCoSo).HasName("PK__ChuCoSo__00A84573CBDEEE84");

            entity.ToTable("ChuCoSo");

            entity.Property(e => e.IdchuCoSo).HasColumnName("IDChuCoSo");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .HasColumnName("CCCD");
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdchucVu).HasName("PK__ChucVu__70FCCF651F69E157");

            entity.ToTable("ChucVu");

            entity.Property(e => e.IdchucVu).HasColumnName("IDChucVu");
            entity.Property(e => e.TenChucVu).HasMaxLength(50);
        });

        modelBuilder.Entity<CoSo>(entity =>
        {
            entity.HasKey(e => e.IdcoSo).HasName("PK__CoSo__344441C5AC6FA1D0");

            entity.ToTable("CoSo");

            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.IdchuCoSo).HasColumnName("IDChuCoSo");
            entity.Property(e => e.LoaiHinhKinhDoanh).HasMaxLength(100);
            entity.Property(e => e.NgayCapCnattp).HasColumnName("NgayCapCNATTP");
            entity.Property(e => e.NgayCapGiayPhepKd).HasColumnName("NgayCapGiayPhepKD");
            entity.Property(e => e.NgayHetHanCnattp).HasColumnName("NgayHetHanCNATTP");
            entity.Property(e => e.SoGiayPhepKd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SoGiayPhepKD");
            entity.Property(e => e.TenCoSo).HasMaxLength(100);

            entity.HasOne(d => d.IdchuCoSoNavigation).WithMany(p => p.CoSos)
                .HasForeignKey(d => d.IdchuCoSo)
                .HasConstraintName("FK__CoSo__IDChuCoSo__3E52440B");
        });

        modelBuilder.Entity<HoSoCapGiayChungNhan>(entity =>
        {
            entity.HasKey(e => e.IdgiayChungNhan).HasName("PK__HoSoCapG__729C7BB608FDDF38");

            entity.ToTable("HoSoCapGiayChungNhan");

            entity.Property(e => e.IdgiayChungNhan).HasColumnName("IDGiayChungNhan");
            entity.Property(e => e.HinhAnhMinhChung)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.LoaiThucPham).HasMaxLength(100);

            entity.HasOne(d => d.IdcoSoNavigation).WithMany(p => p.HoSoCapGiayChungNhans)
                .HasForeignKey(d => d.IdcoSo)
                .HasConstraintName("FK__HoSoCapGi__IDCoS__412EB0B6");
        });

        modelBuilder.Entity<KeHoach>(entity =>
        {
            entity.HasKey(e => e.IdkeHoach).HasName("PK__KeHoach__936F11C84F1A9601");

            entity.ToTable("KeHoach");

            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.Loai).HasMaxLength(100);
            entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");
        });

        modelBuilder.Entity<KeHoachCoSo>(entity =>
        {
            entity.HasKey(e => e.IdkeHoachCoSo).HasName("PK__KeHoach___146E827EE255FF23");

            entity.ToTable("KeHoach_CoSo");

            entity.Property(e => e.IdkeHoachCoSo).HasColumnName("IDKeHoachCoSo");
            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.KetLuan).HasMaxLength(200);
            entity.Property(e => e.KhacPhuc).HasMaxLength(200);
            entity.Property(e => e.ThoiGianKiemTra).HasColumnType("datetime");
            entity.Property(e => e.YkienChuCoSo)
                .HasMaxLength(200)
                .HasColumnName("YKienChuCoSo");

            entity.HasOne(d => d.IdcoSoNavigation).WithMany(p => p.KeHoachCoSos)
                .HasForeignKey(d => d.IdcoSo)
                .HasConstraintName("FK__KeHoach_C__IDCoS__571DF1D5");

            entity.HasOne(d => d.IdkeHoachNavigation).WithMany(p => p.KeHoachCoSos)
                .HasForeignKey(d => d.IdkeHoach)
                .HasConstraintName("FK__KeHoach_C__IDKeH__5629CD9C");
        });

        modelBuilder.Entity<MucKiemTra>(entity =>
        {
            entity.HasKey(e => e.IdmucKt).HasName("PK__MucKiemT__2452E27E64B252C2");

            entity.ToTable("MucKiemTra");

            entity.Property(e => e.IdmucKt).HasColumnName("IDMucKT");
            entity.Property(e => e.NoiDung).HasMaxLength(200);
        });

        modelBuilder.Entity<ThongBaoThayDoi>(entity =>
        {
            entity.HasKey(e => e.IdthongBao).HasName("PK__ThongBao__3EBBFAAEF51CB427");

            entity.ToTable("ThongBaoThayDoi");

            entity.Property(e => e.IdthongBao).HasColumnName("IDThongBao");
            entity.Property(e => e.DiaChiMoi).HasMaxLength(100);
            entity.Property(e => e.IdchuCoSoMoi).HasColumnName("IDChuCoSoMoi");
            entity.Property(e => e.IdcoSo).HasColumnName("IDCoSo");
            entity.Property(e => e.TenCoSoMoi).HasMaxLength(100);

            entity.HasOne(d => d.IdchuCoSoMoiNavigation).WithMany(p => p.ThongBaoThayDois)
                .HasForeignKey(d => d.IdchuCoSoMoi)
                .HasConstraintName("FK__ThongBaoT__IDChu__47DBAE45");

            entity.HasOne(d => d.IdcoSoNavigation).WithMany(p => p.ThongBaoThayDois)
                .HasForeignKey(d => d.IdcoSo)
                .HasConstraintName("FK__ThongBaoT__IDCoS__46E78A0C");
        });

        modelBuilder.Entity<TinTuc>(entity =>
        {
            entity.HasKey(e => e.IdtinTuc).HasName("PK__TinTuc__74C0F8F80503928C");

            entity.ToTable("TinTuc");

            entity.Property(e => e.IdtinTuc).HasColumnName("IDTinTuc");
            entity.Property(e => e.IdcanBo).HasColumnName("IDCanBo");
            entity.Property(e => e.NoiDung).HasColumnType("text");
            entity.Property(e => e.TieuDe).HasMaxLength(50);

            entity.HasOne(d => d.IdcanBoNavigation).WithMany(p => p.TinTucs)
                .HasForeignKey(d => d.IdcanBo)
                .HasConstraintName("FK__TinTuc__IDCanBo__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
