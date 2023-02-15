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
    /// Логика взаимодействия для Task18.xaml
    /// </summary>
    public partial class Task18 : Page
    {
        public Task18()
        {
            InitializeComponent();
        }
        private void BTN18_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(TBk.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"R = {Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835) / (Math.Log10(y) + k) + 3 * Math.Pow(y, 2)}", "задание 1.18",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.18",
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
