using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ListingBoard.Pages
{
    public partial class UserPage : Page
    {
        private Entities Context = Entities.GetContext();
        private List<Listings> Listings = new List<Listings>();
        private Users userdata;

        public UserPage()
        {
            InitializeComponent();
            LoadListings();
        }

        private void LoadListings()
        {
            if (Application.Current.MainWindow is MainWindow mainWindow && mainWindow.userdata != null)
            {
                userdata = mainWindow.userdata;

                Listings = Context.Listings
                    .Where(l => l.UserID == userdata.ID)
                    .ToList();

                lvListingsList.ItemsSource = Listings;
            }
            else
            {
                MessageBox.Show("Ошибка: Не удалось определить текущего пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lvListingsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvListingsList.SelectedItem is Listings selectedListing)
            {
                NavigationService?.Navigate(new ListingEditPage(selectedListing));
            }
        }

        private void btnAddListing_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow) mainWindow.frMainFrame.Navigate(new ListingEditPage());
        }

        private void btnDeleteListing_Click(object sender, RoutedEventArgs e)
        {
            if (lvListingsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите объявления для удаления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные объявления?", "Подтверждение",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }

            using (var context = new Entities())
            {
                var selectedListings = lvListingsList.SelectedItems.Cast<Listings>().ToList();

                foreach (var listing in selectedListings)
                {
                    var listingToDelete = context.Listings.Find(listing.ID);
                    if (listingToDelete != null)
                    {
                        context.Listings.Remove(listingToDelete);
                    }
                }

                context.SaveChanges();
            }

            LoadListings();
        }
    }
}
