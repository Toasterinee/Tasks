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
    /// Логика взаимодействия для Task23.xaml
    /// </summary>
    public partial class Task23 : Page
    {
        public Task23()
        {
            InitializeComponent();
        }

        private void BTN23_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 5.2, y = 0, a = 0, b = 0.3, t = 0;
                t = x * Math.Pow(b, 2) + Math.Sqrt(x);
                x = Math.Log10(Math.Abs(t * x + Math.Pow(b, 2)));
                y = Math.Pow(Math.ILogB(Math.Pow(a,2)/(a + t)), a + b);
                MessageBox.Show($"y = {y}\na = {a}\nt = {t}", "задание 1.23",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.23",
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
