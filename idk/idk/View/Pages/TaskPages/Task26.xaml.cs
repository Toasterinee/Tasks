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
    /// Логика взаимодействия для Task26.xaml
    /// </summary>
    public partial class Task26 : Page
    {
        public Task26()
        {
            InitializeComponent();
        }

        private void BTN26_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, t = 2, b = 8.1, a = 0;
                t = Math.Sqrt(b + Math.Pow(t, 2));
                x = Math.Pow(Math.Cos(b),2) + Math.Pow(Math.Sin(a),2);
                y = Math.Pow(x, 2) / Math.Pow(Math.Sqrt(Math.Abs(x)),3);
                MessageBox.Show($"y = {y}\nx = {x}\na = {a}", "задание 1.26",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.26",
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
