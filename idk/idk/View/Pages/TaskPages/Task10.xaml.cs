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
    /// Логика взаимодействия для Task10.xaml
    /// </summary>
    public partial class Task10 : Page
    {
        public Task10()
        {
            InitializeComponent();
        }

        private void BTN10_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 2.8, y = 0, a = 0, b = 1.3, c = 0;
                c = Math.Pow(a,  2) + Math.Sqrt(b);
                a = Math.Pow(b,3) + Math.ILogB(Math.Sqrt(b));
                y = Math.Exp(x) + Math.Pow(5.8, c);
                MessageBox.Show($"y = {y}\nx = {x}\nc = {c}", "задание 1.10",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.10",
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
