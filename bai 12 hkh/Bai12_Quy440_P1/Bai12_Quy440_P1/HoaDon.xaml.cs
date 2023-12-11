using Bai12_Quy440_P1.QLTaiKhoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai12_Quy440_P1
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        public HoaDon()
        {
            InitializeComponent();
            tbNgayLap.Text = DateTime.Now.ToString("dd-MM-yyyy");
            HienThi();
        }

        private void btnSL_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraHangMua())
            {
                QltaiKhoanContext db = new QltaiKhoanContext();
                QLTaiKhoan.HangMua hm = new QLTaiKhoan.HangMua();
                hm.MaHang = tbMaHang.Text;
                hm.TenHang = tbTenHang.Text;
                hm.DonGia = decimal.Parse(tbDonGia.Text);
                hm.SoLuong = int.Parse(tbSoLuong.Text);
                db.HangMuas.Add(hm);
                db.SaveChanges();
                HienThi();
            }
        }
        public void HienThi()
        {
            QltaiKhoanContext db = new QltaiKhoanContext();
            var query = from hm in db.HangMuas select hm;
            dtgHoaDon.ItemsSource = query.ToList();
        }
        public bool KiemTraHangMua()
        {
            QltaiKhoanContext db = new QltaiKhoanContext();
            var query = from d in db.HangMuas where d.MaHang.Equals(tbMaHang.Text) select d;
            if (query.Count() > 0)
            {
                MessageBox.Show("Mã hàng đã tồn tại!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbMaHang.Focus();
                return false;
            }
            if (tbMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbMaHang.Focus();
                return false;
            }
            if (tbTenHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbTenHang.Focus();
                return false;
            }
            if (tbSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbSoLuong.Focus();
                return false;
            }
            if (tbDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbDonGia.Focus();
                return false;
            }
            try
            {
                int soluong = int.Parse(tbSoLuong.Text);
                if (soluong < 0)
                {
                    MessageBox.Show("Số lượng không âm!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    tbSoLuong.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbSoLuong.Focus();
                return false;
            }
            try
            {
                decimal dongia = decimal.Parse(tbSoLuong.Text);
                if (dongia < 0)
                {
                    MessageBox.Show("Đơn giá không âm!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    tbDonGia.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbDonGia.Focus();
                return false;
            }
            return true;
        }

        public bool KiemTraHoaDon()
        {
            QltaiKhoanContext db = new QltaiKhoanContext();
            var query = from d in db.HoaDons where d.SoHoaDon.Equals(tbSoHoaDon.Text) select d;
            if (query.Count() > 0)
            {
                MessageBox.Show("Số hóa đơn đã tồn tại!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbSoHoaDon.Focus();
                return false;
            } 
            if (tbSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbSoDienThoai.Focus();
                return false;
            }
            if (tbSoHoaDon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số hóa đơn!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbSoHoaDon.Focus();
                return false;
            }
            if (tbHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên khách hàng!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbHoTen.Focus();
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraHoaDon())
            {
                QltaiKhoanContext db = new QltaiKhoanContext();
                QLTaiKhoan.HoaDon hd = new QLTaiKhoan.HoaDon();
                hd.SoHoaDon = tbSoHoaDon.Text;
                hd.Sdt = tbSoDienThoai.Text;
                hd.NgayLap = Convert.ToDateTime(tbNgayLap.Text);
                hd.TenDangNhap = tbTenDangNhap.Text;
                hd.HoTen = tbHoTen.Text;
                db.HoaDons.Add(hd);
                db.SaveChanges();
                
            }
        }
    }
}
