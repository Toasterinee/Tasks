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
    /// Логика взаимодействия для Task27.xaml
    /// </summary>
    public partial class Task27 : Page
    {
        public Task27()
        {
            InitializeComponent();
        }

        private void BTN27_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, t = -3, c = 0, a = 76;
                c = Math.Pow(t,2) + Math.Sqrt(a);
                x = Math.ILogB(Math.Abs(c*t)) + Math.Pow(a, 2);
                y = Math.Tan(4*x) + Math.Pow(Math.Sin(x),2);
                MessageBox.Show($"y = {y}\nx = {x}\nc = {a}", "задание 1.27",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.27",
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
