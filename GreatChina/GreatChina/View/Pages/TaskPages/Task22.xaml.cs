﻿using System;
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
    /// Логика взаимодействия для Task22.xaml
    /// </summary>
    public partial class Task22 : Page
    {
        public Task22()
        {
            InitializeComponent();
        }
        private void BTN22_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TBt.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"S = {4.351 * Math.Pow(y, 3) + 2 * t * Math.Log10(t) / (Math.Sqrt(Math.Cos(2) * y) + 4.351)}", "задание 1.22",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.22",
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
