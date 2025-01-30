using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System;
using ListingBoard.Pages;


namespace ListingBoard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Users userdata { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (frMainFrame.CanGoBack) frMainFrame.GoBack();
        }

        private void frMainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            this.Title = $"{page.Title}";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            frMainFrame.NavigationService.Navigate(new LoginPage());
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            frMainFrame.NavigationService.Navigate(new ListingsPage());
        }

        private void btnUserPage_Click(object sender, RoutedEventArgs e)
        {
            frMainFrame.NavigationService.Navigate(new UserPage());
        }
    }
}
