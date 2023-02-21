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
    /// Логика взаимодействия для Task12.xaml
    /// </summary>
    public partial class Task12 : Page
    {
        public Task12()
        {
            InitializeComponent();
        }

        private void BTN12_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, q = 2, b = 1.8, t = 0;
                t = Math.Pow(b, 3) + Math.Exp(Math.Sqrt(q));
                x = Math.Pow(t,3) + Math.Pow(b, 2);
                y = Math.Pow(Math.Atan(Math.Sqrt(x)),2);
                MessageBox.Show($"y = {y}\nx = {x}\nt = {t}", "задание 1.12",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.12",
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
