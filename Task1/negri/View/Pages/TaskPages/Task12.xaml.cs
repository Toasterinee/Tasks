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
    /// Логика взаимодействия для Task12.xaml
    /// </summary>
    public partial class Task12 : Page
    {
        public Task12()
        {
            InitializeComponent();
        }

        private void BTN12_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TBt.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"R = {Math.Pow((Math.Sin(2) * t + 1), 2) + 0.3 / (Math.Log10(t) + y)}", "задание 1.12",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.12",
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
