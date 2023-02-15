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
    /// Логика взаимодействия для Task28.xaml
    /// </summary>
    public partial class Task28 : Page
    {
        public Task28()
        {
            InitializeComponent();
        }
        private void BTN28_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double v = Convert.ToDouble(TBv.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"W = {0.004 * v + Math.Pow(Math.Exp(2), y) / (Math.Exp(y) / 2)}", "задание 1.28",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.28",
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
