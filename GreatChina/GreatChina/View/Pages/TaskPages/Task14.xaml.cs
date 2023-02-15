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
    /// Логика взаимодействия для Task14.xaml
    /// </summary>
    public partial class Task14 : Page
    {
        public Task14()
        {
            InitializeComponent();
        }
        private void BTN14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(TBh.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"P = {Math.Exp(y + 2.5) + 7.1 * Math.Pow(h, 3) / (Math.Log10(Math.Sqrt(y + 0.004 * h)))}", "задание 1.11",
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
