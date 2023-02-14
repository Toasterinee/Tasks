using negri.View.Pages;
using System.Windows;
using static negri.Core.Core;

namespace negri
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
