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
    /// Логика взаимодействия для Task24.xaml
    /// </summary>
    public partial class Task24 : Page
    {
        public Task24()
        {
            InitializeComponent();
        }

        private void BTN24_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, b = 1.8, t = 6.2, a = 0;
                a = Math.Pow(t,2)*b;
                x = Math.Pow(a, 3) + Math.Sqrt(t + b);
                y = Math.Pow(Math.Cos(x), 5) - b * Math.Pow(Math.Sin(x), 2);
                MessageBox.Show($"y = {y}\nx = {x}\na = {a}", "задание 1.24",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.24",
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
