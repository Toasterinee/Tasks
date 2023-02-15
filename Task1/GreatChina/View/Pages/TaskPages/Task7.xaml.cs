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
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        public Task7()
        {
            InitializeComponent();
        }
        public void BTN7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(TBm.Text);
                double y = Convert.ToDouble(TBy5.Text);
                MessageBox.Show($"N = {(Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 2 + 3.6)}", "задание 1.7",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.7",
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
