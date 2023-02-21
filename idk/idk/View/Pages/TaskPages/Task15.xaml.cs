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
    /// Логика взаимодействия для Task15.xaml
    /// </summary>
    public partial class Task15 : Page
    {
        public Task15()
        {
            InitializeComponent();
        }

        private void BTN15_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double p = 4, y = 0, b = 0, x = 0, a = 5.5;
                b = Math.Abs(a) + Math.Sqrt(a + Math.Pow(p, 2));
                x = Math.Exp(b);
                y = Math.Pow(Math.Cos(x), 3) + Math.Abs(a);
                MessageBox.Show($"y = {y}\nx = {x}\nb = {b}", "задание 1.15",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.15",
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
