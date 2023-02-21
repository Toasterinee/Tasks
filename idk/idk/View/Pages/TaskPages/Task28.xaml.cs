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
    /// Логика взаимодействия для Task28.xaml
    /// </summary>
    public partial class Task28 : Page
    {
        public Task28()
        {
            InitializeComponent();
        }

        private void BTN28_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double a = 0, y = 0, b = 2.19, t = 0, k = 1.7;
                t = Math.Pow(k, 2) + Math.Sqrt(b);
                a = b + Math.Pow(t, 2) * Math.Exp(t);
                y = Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);
                MessageBox.Show($"y = {y}\na = {a}\nt = {t}", "задание 1.28",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.28",
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
