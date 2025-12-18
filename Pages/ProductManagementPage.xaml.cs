using Microsoft.Maui.Controls;
using Buyzen.Models;
using System.Collections.ObjectModel;
using System;

namespace Buyzen.Pages
{
    public partial class ProductManagementPage : ContentPage
    {
        private ObservableCollection<Product> Products;

        public ProductManagementPage()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Laptop",
                    Price = 999.99m,
                    Stock = 12,
                    IsVisible = true
                },
                new Product
                {
                    Name = "Headphones",
                    Price = 199.99m,
                    Stock = 3,
                    IsVisible = true
                },
                new Product
                {
                    Name = "Keyboard",
                    Price = 89.99m,
                    Stock = 0,
                    IsVisible = false
                }
            };

            ProductsView.ItemsSource = Products;
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Add Product", "New product flow coming soon.", "OK");
        }

        private async void OnDisableProductClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Disabled", "Selected product has been disabled.", "OK");
        }

        private async void OnUpdateStockClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Stock Updated", "Stock levels updated.", "OK");
        }

        private async void OnSaveProductClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Saved", "Product changes saved successfully.", "OK");
        }
    }
}
