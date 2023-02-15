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
    /// Логика взаимодействия для Task9.xaml
    /// </summary>
    public partial class Task9 : Page
    {
        public Task9()
        {
            InitializeComponent();
        }
        public void BTN9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(TBw1.Text);
                double y = Convert.ToDouble(TBy7.Text);
                MessageBox.Show($"V = {Math.Pow((y + 2 * w),3) / Math.Log10(y + 0.75)}", "задание 1.9",
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
