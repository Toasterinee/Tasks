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
    /// Логика взаимодействия для Task14.xaml
    /// </summary>
    public partial class Task14 : Page
    {
        public Task14()
        {
            InitializeComponent();
        }

        private void BTN14_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double k = 3.4, y = 0, b = 6, t = 0, a = 0;
                t = Math.Pow(b, 2) + Math.Pow(k, 3);
                a = Math.Sqrt(b+t);
                y = Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)),4);
                MessageBox.Show($"y = {y}\na = {a}\nt = {t}", "задание 1.14",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.14",
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
