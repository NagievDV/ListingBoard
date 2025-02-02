using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ListingBoard.Pages
{
    public partial class CompletedListingsPage : Page
    {
        private Entities Context = Entities.GetContext();
        private Users userdata;

        public CompletedListingsPage()
        {
            InitializeComponent();
            LoadCompletedListings();
        }

        private void LoadCompletedListings()
        {
            if (Application.Current.MainWindow is MainWindow mainWindow && mainWindow.userdata != null)
            {
                userdata = mainWindow.userdata;

                var completedListings = Context.Listings
             .Where(l => l.UserID == userdata.ID && l.IsActive == false)
             .ToList()
             .Select(l => new
             {
                 l.ID,
                 l.ListingName,
                 l.ListingDescription,
                 ListingPhoto = string.IsNullOrEmpty(l.ListingPhoto)
                     ? @"E:\Задания\Аксёнова\ListingBoard\ListingBoard\Resources\Images\default.png"
                     : l.ListingPhoto,
                 l.ListingCost
             })
             .ToList();

                lvCompletedListings.ItemsSource = completedListings;

                decimal totalEarnings = completedListings.Sum(l => l.ListingCost);
                lblTotalEarnings.Content = $"{totalEarnings} ₽";
            }
            else
            {
                MessageBox.Show("Ошибка: Не удалось определить текущего пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
