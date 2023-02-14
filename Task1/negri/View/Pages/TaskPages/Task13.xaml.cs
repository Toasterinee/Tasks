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
using static negri.Core.Core;

namespace negri.View.Pages.TaskPages
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
        private void BTN13_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = Convert.ToDouble(TBh.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"D = {Math.Pow(y, 2) + 0.5 * n + 4.8 / Math.Sin(y)}", "задание 1.13",
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
