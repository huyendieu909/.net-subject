using System;
using System.Collections.Generic;

namespace Bai12_Quy440_P1.QLTaiKhoan;

public partial class HangMua
{
    public string MaHang { get; set; } = null!;

    public string TenHang { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal ThanhTien
    {
        get
        {
            return (decimal)SoLuong * DonGia;
        }
    }
}
