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
    /// Логика взаимодействия для Task30.xaml
    /// </summary>
    public partial class Task30 : Page
    {
        public Task30()
        {
            InitializeComponent();
        }

        private void BTN30_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double t = 3, y = 0, b = 4.2, x = 0, a = 0;
                a = t + Math.Pow(b,3);
                x = Math.Pow(t, 2)*Math.Sqrt(Math.Abs(a + b));
                y = Math.Pow(Math.ILogB(Math.Abs(x + Math.Pow(a,2))),5);
                MessageBox.Show($"y = {y}\nx = {x}\na = {a}", "задание 1.30",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.30",
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
