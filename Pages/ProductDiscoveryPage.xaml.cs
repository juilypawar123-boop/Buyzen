using Buyzen.Models;
using Buyzen.Data;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Buyzen.Pages;

public partial class ProductDiscoveryPage : ContentPage
{
    public ObservableCollection<Product> Products { get; set; }

    public ProductDiscoveryPage()
    {
        InitializeComponent();

        // Initialize Products to all available products
        Products = new ObservableCollection<Product>(Store.AllProducts);

        // Set BindingContext for CollectionView
        BindingContext = this;
    }

    // Navigate to Login Page
    private async void OnLoginSelected(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    // Filter products by category
    private void OnCategorySelected(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        string selectedCategory = button.Text;

        // Clear current displayed products
        Products.Clear();

        // Add only products matching selected category
        foreach (var product in Store.AllProducts.Where(p => p.Category == selectedCategory))
        {
            Products.Add(product);
        }
    }

    // View product details (requires a ProductDetailPage)
    private async void OnViewProduct(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        var product = button.CommandParameter as Product;
        if (product == null) return;

        // Navigate to ProductDetailPage (you need to create this page)
        await Navigation.PushAsync(new ProductDetailPage(product));
    }

    // Add product to Wishlist
    private void OnWishlist(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        var product = button.CommandParameter as Product;
        if (product == null) return;

        if (!Store.Wishlist.Contains(product))
        {
            Store.Wishlist.Add(product);
            DisplayAlert("Wishlist", $"{product.Name} added to your wishlist!", "OK");
        }
        else
        {
            DisplayAlert("Wishlist", $"{product.Name} is already in your wishlist.", "OK");
        }
    }

    // Add product to Cart
    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        if (sender is not Button button) return;

        var product = button.CommandParameter as Product;
        if (product == null) return;

        Store.Cart.Add(product);
        DisplayAlert("Cart", $"{product.Name} added to your cart!", "OK");
    }
}
