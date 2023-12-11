using Bai12_Quy440_P1.QLTaiKhoan;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai12_Quy440_P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            QltaiKhoanContext db = new QltaiKhoanContext();
            if (NgoaiLeDangNhap())
            {
                var query = from tk in db.TaiKhoans where tk.TenDangNhap.Equals(tbTenDangNhap.Text) && tk.MatKhau.Equals(tbMatKhau.Text) select tk;
                if (query.Count() > 0)
                {
                    TaiKhoan tk = query.First();
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.tbTenDangNhap.Text = tbTenDangNhap.Text;
                    hoaDon.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }
        public bool NgoaiLeDangNhap()
        {
            if (tbTenDangNhap.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbTenDangNhap.Focus();
                return false;
            }
            if (tbMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                tbMatKhau.Focus();
                return false;
            }
            return true;
        }
        
    }
}