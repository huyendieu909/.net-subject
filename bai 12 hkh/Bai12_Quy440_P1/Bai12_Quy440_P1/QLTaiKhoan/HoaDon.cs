using System;
using System.Collections.Generic;

namespace Bai12_Quy440_P1.QLTaiKhoan;

public partial class HoaDon
{
    public string SoHoaDon { get; set; } = null!;

    public string? Sdt { get; set; }

    public string HoTen { get; set; } = null!;

    //public DateOnly? NgayLap { get; set; }
    public DateTime? NgayLap { get; set; }

    public string? TenDangNhap { get; set; }

    public virtual TaiKhoan? TenDangNhapNavigation { get; set; }
}
