using System;
using System.Collections.Generic;
using GreatChina.View.Pages;
using System.Windows;
using static GreatChina.Core.Core;

namespace GreatChina
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyCore = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}