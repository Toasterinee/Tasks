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
using static negri.Core.Core;

namespace negri.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task21.xaml
    /// </summary>
    public partial class Task21 : Page
    {
        public Task21()
        {
            InitializeComponent();
        }
        private void BTN21_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double p = Convert.ToDouble(TBp.Text);
                double d = Convert.ToDouble(TBd.Text);
                double k = Convert.ToDouble(TBk.Text);
                double x = Convert.ToDouble(TBx.Text);
                MessageBox.Show($"K = {(Math.Sqrt(k) + 2.6 * p * Math.Sin(k)) / x - Math.Pow(d, 3)}", "задание 1.21",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.21",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }
    }
}
