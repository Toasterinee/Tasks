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
    /// Логика взаимодействия для Task26.xaml
    /// </summary>
    public partial class Task26 : Page
    {
        public Task26()
        {
            InitializeComponent();
        }
        private void BTN26_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double u = Convert.ToDouble(TBu.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"T = {Math.Sin(2) * u / (Math.Log(y) * y + u)}", "задание 1.26",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.26",
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
