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
    /// Логика взаимодействия для Task25.xaml
    /// </summary>
    public partial class Task25 : Page
    {
        public Task25()
        {
            InitializeComponent();
        }

        private void BTN25_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, t = 0, p = 2.6, a = 2;
                t = Math.Pow(p, 3) + Math.Pow(a, 3);
                x = Math.Exp(Math.Sqrt(p + a));
                y = Math.Pow(x, 3) / Math.Pow(t, 2);
                MessageBox.Show($"y = {y}\nx = {x}\nt = {t}", "задание 1.25",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.25",
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
