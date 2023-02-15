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
    /// Логика взаимодействия для Task30.xaml
    /// </summary>
    public partial class Task30 : Page
    {
        public Task30()
        {
            InitializeComponent();
        }
        private void BTN30_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double p = Convert.ToDouble(TBp.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"N = {3 * Math.Pow(y, 2) + Math.Sqrt(y + 1) / Math.Log10(p + y) + Math.Exp(p)}", "задание 1.30",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.30",
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
