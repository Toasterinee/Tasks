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
    /// Логика взаимодействия для Task16.xaml
    /// </summary>
    public partial class Task16 : Page
    {
        public Task16()
        {
            InitializeComponent();
        }
        public void BTN16_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(TBr.Text);
                double t = Convert.ToDouble(TBt.Text);
                double y = Convert.ToDouble(TBy.Text);
                MessageBox.Show($"W = {4 * Math.Pow(t, 3) + Math.Log10(r) / Math.Pow(Math.Exp(y), +r)}", "задание 1.16",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка วกดสเา้กดน้เ่", "задание 1.16",
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
