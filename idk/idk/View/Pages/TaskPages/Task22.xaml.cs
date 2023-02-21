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
using static idk.Core.Core;

namespace idk.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task22.xaml
    /// </summary>
    public partial class Task22 : Page
    {
        public Task22()
        {
            InitializeComponent();
        }

        private void BTN22_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, p = 4, m = 5.7, t = 0;
                t = Math.Pow(Math.Sin(m),3);
                x = Math.Pow(p, 2) + t;
                y = Math.Pow(Math.Log10(Math.Abs(x + t)),4);
                MessageBox.Show($"y = {y}\nx = {x}\nt = {t}", "задание 1.22",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.22",
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
