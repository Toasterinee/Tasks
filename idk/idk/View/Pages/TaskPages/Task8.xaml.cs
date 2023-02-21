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
    /// Логика взаимодействия для Task8.xaml
    /// </summary>
    public partial class Task8 : Page
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void BTN8_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, c = 3.7, b = 2.2, a = 0;
                x = a + Math.Pow((b + c), 3);
                a = Math.Sin(b);
                y = 7 * Math.Exp(Math.Sqrt(Math.Abs(x)) + Math.Pow(Math.Cos(x), 4));
                MessageBox.Show($"y = {y}\n x = {x}\na = {a}", "задание 1.8",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.8",
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
