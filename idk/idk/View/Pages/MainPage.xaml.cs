using idk.View.Pages.TaskPages;
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
using static idk.Core.Core;

namespace idk.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MNBTN15_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task15());
        }

        private void MNBTN14_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task14());
        }

        private void MNBTN13_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task13());
        }

        private void MNBTN12_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task12());
        }

        private void MNBTN11_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task11());
        }

        private void MNBTN10_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task10());
        }

        private void MNBTN9_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task9());
        }

        private void MNBTN8_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task8());
        }

        private void MNBTN7_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task7());
        }


        private void MNBTN22_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task22());
        }

        private void MNBTN23_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task23());
        }

        private void MNBTN24_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task24());
        }

        private void MNBTN25_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task25());
        }

        private void MNBTN26_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task26());
        }

        private void MNBTN27_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task27());
        }

        private void MNBTN28_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task28());
        }

        private void MNBTN29_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task29());
        }

        private void MNBTN30_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task30());
        }

    }
}