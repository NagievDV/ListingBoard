using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ListingBoard.ViewModels;

namespace ListingBoard.Pages
{
    public partial class ListingsPage : Page
    {
        private Entities Context = Entities.GetContext();
        private List<ListingViewModel> Listings = new List<ListingViewModel>();

        public ListingsPage()
        {
            InitializeComponent();

            cmbCategory.ItemsSource = Context.Categories.ToList();
            cmbCategory.DisplayMemberPath = "CategoryName";
            cmbCategory.SelectedValuePath = "ID";

            cmbCity.ItemsSource = Context.Cities.ToList();
            cmbCity.DisplayMemberPath = "CityName";
            cmbCity.SelectedValuePath = "ID";

            cmbType.ItemsSource = Context.ListingTypes.ToList();
            cmbType.DisplayMemberPath = "TypeName";
            cmbType.SelectedValuePath = "ID";

            LoadListings();
            SetupFilters();
        }

        private void LoadListings()
        {
            Listings = Context.Listings
                .Where(l => (bool)l.IsActive)
                .Select(l => new ListingViewModel
                {
                    ListingName = l.ListingName,
                    ListingDescription = l.ListingDescription,
                    ListingPrice = l.ListingCost + " ₽",
                    Photo = string.IsNullOrEmpty(l.ListingPhoto) ? @"E:\Задания\Аксёнова\ListingBoard\ListingBoard\Resources\Images\default.png" : l.ListingPhoto,
                    PublicationDate = l.PublicationDate.HasValue ? "от: " + l.PublicationDate.Value : "Не указана",
                    CityID = l.CityID,
                    CategoryID = l.CategoryID,
                    TypeID = l.ListingTypeID
                })
                .ToList();

            ApplyFilters();
        }

        private void SetupFilters()
        {
            tbSearch.TextChanged += (s, e) => ApplyFilters();
            cmbCity.SelectionChanged += (s, e) => ApplyFilters();
            cmbCategory.SelectionChanged += (s, e) => ApplyFilters();
            cmbType.SelectionChanged += (s, e) => ApplyFilters();
        }

        private void ApplyFilters()
        {
            string searchText = tbSearch.Text.ToLower();
            int? selectedCity = cmbCity.SelectedValue as int?;
            int? selectedCategory = cmbCategory.SelectedValue as int?;
            int? selectedType = cmbType.SelectedValue as int?;

            var filteredListings = Listings.Where(l =>
                (string.IsNullOrEmpty(searchText) || l.ListingName.ToLower().Contains(searchText) || l.ListingDescription.ToLower().Contains(searchText)) &&
                (!selectedCity.HasValue || l.CityID == selectedCity) &&
                (!selectedCategory.HasValue || l.CategoryID == selectedCategory) &&
                (!selectedType.HasValue || l.TypeID == selectedType)
            ).ToList();

            lvListingsList.ItemsSource = filteredListings;
        }
        private void cmbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void cmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            tbSearch.Text = string.Empty;
            cmbCategory.SelectedItem = null;
            cmbCity.SelectedItem = null;
            cmbType.SelectedItem = null;
            ApplyFilters();
        }
    }

}
