using System;

public class SinhVien
{
	private string maSinhVien;
	private string hoTen;
    public string MaSinhVien { get; set; }
	public string HoTen { get; set; }
	public SinhVien() { }
	public SinhVien(string maSinhVien, string hoTen)
	{
		MaSinhVien = maSinhVien;
		HoTen = hoTen;
	}
    public override string ToString()
    {
        return string.Format($"{MaSinhVien, -15}{HoTen, 20}");
    }
}
