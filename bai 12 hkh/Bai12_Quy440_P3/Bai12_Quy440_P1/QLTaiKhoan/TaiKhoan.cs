using System;
using System.Collections.Generic;

namespace Bai12_Quy440_P1.QLTaiKhoan;

public partial class TaiKhoan
{
    public string TenDangNhap { get; set; } = null!;

    public string? MatKhau { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
