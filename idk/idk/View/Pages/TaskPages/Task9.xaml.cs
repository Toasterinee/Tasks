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
    /// Логика взаимодействия для Task9.xaml
    /// </summary>
    public partial class Task9 : Page
    {
        public Task9()
        {
            InitializeComponent();
        }

        private void BTN9_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double x = 0, y = 0, k = 1, m = 1.8, c = 0;
                x = Math.Exp(m*k);
                c = Math.Pow(Math.Cos(m), 2) + Math.Pow(k, 2);
                y = Math.Pow(Math.Sqrt(Math.Pow(x,2)+ Math.Pow(c, 2)), 3);
                MessageBox.Show($"y = {y}\nx = {x}\nc = {c}", "задание 1.9",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.9",
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
