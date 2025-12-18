using Buyzen.Models;
using Buyzen.Data;

namespace Buyzen.Pages;

public partial class ProductDetailPage : ContentPage
{
    private Product CurrentProduct;

    public ProductDetailPage(Product product)
    {
        InitializeComponent();
        CurrentProduct = product;

        // Populate UI
        ProductImage.Source = product.ImageUrl;
        ProductName.Text = product.Name;
        ProductCategory.Text = $"Category: {product.Category}";
        ProductPrice.Text = $"${product.Price:F2}";
        ProductDescription.Text = product.ShortDescription;
    }

    private void OnWishlistClicked(object sender, EventArgs e)
    {
        if (!Store.Wishlist.Contains(CurrentProduct))
        {
            Store.Wishlist.Add(CurrentProduct);
            DisplayAlert("Wishlist", $"{CurrentProduct.Name} added to your wishlist!", "OK");
        }
    }

    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        Store.Cart.Add(CurrentProduct);
        DisplayAlert("Cart", $"{CurrentProduct.Name} added to your cart!", "OK");
    }
}
