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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HoangXuanQuy_440_proj10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Menu3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu3 click");
        }

        private void Menu22_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu22 click");
        }

        private void Bold_tb(object sender, RoutedEventArgs e)
        {
            tb.FontWeight = FontWeights.Bold;
        }

        private void Unbold_tb(object sender, RoutedEventArgs e)
        {
            tb.FontWeight = FontWeights.Normal;
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            tb.FontStyle = FontStyles.Italic;
        }
    }
}
