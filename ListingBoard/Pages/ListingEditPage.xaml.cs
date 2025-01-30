using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ListingBoard;

namespace ListingBoard.Pages
{
    public partial class ListingEditPage : Page
    {
        private Entities Context = Entities.GetContext();
        private Listings CurrentListing;
        private bool IsNewListing = false;

        public ListingEditPage(Listings listing = null)
        {
            InitializeComponent();
            LoadData();

            if ((listing == null) && (Application.Current.MainWindow is MainWindow mainWindow))
            {
                CurrentListing = new Listings
                {
                    UserID = mainWindow.userdata.ID,
                    PublicationDate = DateTime.Now,
                    IsActive = true
                };
                IsNewListing = true;
            }
            else
            {
                CurrentListing = listing;
            }

            DataContext = CurrentListing;
        }

        private void LoadData()
        {
            cmbCities.ItemsSource = Context.Cities.ToList();
            cmbCategories.ItemsSource = Context.Categories.ToList();
            cmbListingTypes.ItemsSource = Context.ListingTypes.ToList();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (IsNewListing)
            {
                Context.Listings.Add(CurrentListing);
            }

            Context.SaveChanges();
            MessageBox.Show("Объявление успешно сохранено!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService?.Navigate(new ListingsPage());
            
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
