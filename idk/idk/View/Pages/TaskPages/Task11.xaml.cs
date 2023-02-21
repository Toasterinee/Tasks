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
    /// Логика взаимодействия для Task11.xaml
    /// </summary>
    public partial class Task11 : Page
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void BTN11_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 2, y = 0, a = 0, b = 7, c = 0;
                c = Math.Log10(Math.Abs(b));
                a = Math.Pow(b + x, 3);
                y = Math.Pow(c,2) + Math.Sqrt(Math.Abs(a));
                MessageBox.Show($"y = {y}\nc = {c}\na = {a}", "задание 1.11",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.11",
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
