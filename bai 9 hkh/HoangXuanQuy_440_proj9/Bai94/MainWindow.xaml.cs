﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai94
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
        double soKwTieuThu, tongTien;

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            lstThongTin.Items.Clear();
            lstThongTin.Items.Add(cboHoTen.Text);
            lstThongTin.Items.Add("Số kw tiêu thụ: " + soKwTieuThu);
            lstThongTin.Items.Add("Tổng tiền: " + tongTien.ToString("N0"));

        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?","Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            double chiSoCu, chiSoMoi, sokwTrongDinhMuc, sokwVuotDinhMuc = 0;
            chiSoCu = double.Parse(txtChiSoCu.Text);
            chiSoMoi = double.Parse(txtChiSoMoi.Text);
            soKwTieuThu = chiSoMoi - chiSoCu;
            if (soKwTieuThu <= 50)
            {
                sokwTrongDinhMuc = soKwTieuThu;
                tongTien = soKwTieuThu * 500;
            }
            else
            {
                sokwTrongDinhMuc = 50;
                sokwVuotDinhMuc = soKwTieuThu - 50;
                tongTien = 25000 + sokwVuotDinhMuc * 1000;
            }

            txtSoKwTieuThu.Text = soKwTieuThu.ToString();
            txtTongTien.Text = tongTien.ToString("N0");
            txtSoKwDinhMuc.Text = sokwTrongDinhMuc.ToString();
            txtSoKwVuotDinhMuc.Text = sokwVuotDinhMuc.ToString();

        }
    }
}
