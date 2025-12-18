using Buyzen.Models;
using Buyzen.Data;
using Microsoft.Maui.Controls;
using System;

namespace Buyzen.Pages
{
    public partial class WishlistPage : ContentPage
    {
        public WishlistPage()
        {
            InitializeComponent();
            WishlistView.ItemsSource = Store.Wishlist;
        }

        private void OnMoveToCartClicked(object sender, EventArgs e)
        {
            var product = (sender as Button)?.CommandParameter as Product;
            if (product == null) return;

            Store.Cart.Add(product);
            Store.Wishlist.Remove(product);

            DisplayAlert("Moved to Cart", $"{product.Name} added to cart.", "OK");
        }

        private void OnRemoveFromWishlistClicked(object sender, EventArgs e)
        {
            var product = (sender as Button)?.CommandParameter as Product;
            if (product == null) return;

            Store.Wishlist.Remove(product);
        }

        private async void OnPriceAlertClicked(object sender, EventArgs e)
        {
            var product = (sender as Button)?.CommandParameter as Product;
            if (product == null) return;

            await DisplayAlert(
                "Price Alert",
                $"You’ll be notified when {product.Name} price changes.",
                "OK");
        }
    

    }
}
