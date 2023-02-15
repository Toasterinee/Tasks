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
    /// Логика взаимодействия для Task15.xaml
    /// </summary>
    public partial class Task15 : Page
    {
        public Task15()
        {
            InitializeComponent();
        }
        private void BTN15_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double j = Convert.ToDouble(TBj.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"F = {2 * (Math.Sin(0.354) * y + 1) / (Math.Log10(y) + 2 * j)}", "задание 1.15",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.15",
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

