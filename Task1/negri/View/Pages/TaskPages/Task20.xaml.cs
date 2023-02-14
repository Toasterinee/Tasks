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
    /// Логика взаимодействия для Task20.xaml
    /// </summary>
    public partial class Task20 : Page
    {
        public Task20()
        {
            InitializeComponent();
        }
        private void BTN20_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double l = Convert.ToDouble(TBl.Text);
                double t = Convert.ToDouble(TBt.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"K = {2 * Math.Pow(t, 2) + 3 * l + 7.2 / Math.Log10(y) + Math.Pow(Math.Exp(2), l)}", "задание 1.11",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.11",
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
