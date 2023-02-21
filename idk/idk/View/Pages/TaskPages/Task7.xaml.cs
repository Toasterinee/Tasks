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
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        public Task7()
        {
            InitializeComponent();
        }

        public void BTN7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = 8.2, x = 5, a=1, c=1;
                a = Math.Pow(c, 3) + k;
                c = Math.Sqrt(x);
                MessageBox.Show($"y = {Math.Pow(Math.Log10(a),3) + Math.Pow(Math.Cos(x), 5)}\na = {Math.Pow(c, 3) + k}\nc = {Math.Sqrt(x)}", " задание 1.1",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.1",
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
