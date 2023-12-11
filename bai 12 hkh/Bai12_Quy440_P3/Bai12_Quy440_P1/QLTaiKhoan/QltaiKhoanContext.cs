using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bai12_Quy440_P1.QLTaiKhoan;

public partial class QltaiKhoanContext : DbContext
{
    public QltaiKhoanContext()
    {
    }

    public QltaiKhoanContext(DbContextOptions<QltaiKhoanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HangMua> HangMuas { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=huyen-dieu-acer;Initial Catalog=QLTaiKhoan;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HangMua>(entity =>
        {
            entity.HasKey(e => e.MaHang).HasName("PK__HangMua__19C0DB1D3602F5C6");

            entity.ToTable("HangMua");

            entity.Property(e => e.MaHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.TenHang).HasMaxLength(128);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.SoHoaDon).HasName("PK__HoaDon__012E9E523B963A45");

            entity.ToTable("HoaDon");

            entity.Property(e => e.SoHoaDon)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.Sdt)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.TenDangNhap)
                .HasConstraintName("fk");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__TaiKhoan__55F68FC15491775A");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
