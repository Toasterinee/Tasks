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
using static GreatChina.Core.Core;

namespace GreatChina.View.Pages.TaskPages
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
        private void BTN29_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(TBh.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"T = {0.355 * Math.Pow(h, 2) - 4.355 / Math.Exp(y + h) + Math.Sqrt(2.7 * y)}", "задание 1.29",
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
