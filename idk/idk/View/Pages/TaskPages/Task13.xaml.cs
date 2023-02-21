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
    /// Логика взаимодействия для Task13.xaml
    /// </summary>
    public partial class Task13 : Page
    {
        public Task13()
        {
            InitializeComponent();
        }

        private void BTN13_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                double z = 0, y = 0, w = 0, x = 1.9, a = -0.9;
                w = Math.Pow(x,2)*Math.Sqrt(Math.Abs(a + x));
                z = Math.Pow(Math.Cos(a),2) + Math.Pow(w, 2);
                y = a*Math.Pow(z,7) + Math.Pow(Math.Sin(w),2);
                MessageBox.Show($"y = {y}\nz = {z}\nw = {w}", "задание 1.13",
                MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.13",
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
