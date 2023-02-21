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
    /// Логика взаимодействия для Task29.xaml
    /// </summary>
    public partial class Task29 : Page
    {
        public Task29()
        {
            InitializeComponent();
        }

        private void BTN29_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double p = 0, y = 0, b = 4.3, x = 0, a = 6;
                x = Math.Exp(2*a) + Math.Sqrt(b);
                p = x * (a + Math.Pow(b,3));
                y = Math.Pow(Math.Log10(Math.Abs(p) + x),3);
                MessageBox.Show($"y = {y}\np = {p}\nx = {x}", "задание 1.29",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.29",
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
