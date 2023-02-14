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
using static negri.Core.Core;

namespace negri.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task23.xaml
    /// </summary>
    public partial class Task23 : Page
    {
        public Task23()
        {
            InitializeComponent();
        }
        private void BTN23_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(TBd.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"R = {Math.Pow(Math.Sin(y), 2) + 0.3 * d / Math.Exp(y) + Math.Log10(d)}", "задание 1.23",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.23",
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
