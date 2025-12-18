using Buyzen.Data;
using Buyzen.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Buyzen.Pages;

public partial class ShoppingCartPage : ContentPage
{
    public ObservableCollection<CartItemModel> CartItems { get; set; }

    public ShoppingCartPage()
    {
        InitializeComponent();

        // Load CartItems from global Store or DataStore
        CartItems = new ObservableCollection<CartItemModel>(Store.Cart.Select(p => new CartItemModel
        {
            Product = p,
            Quantity = 1
        }));

        CartItemsView.ItemsSource = CartItems;

        UpdatePriceSummary();
    }

    private void OnQuantityChanged(object sender, ValueChangedEventArgs e)
    {
        UpdatePriceSummary();
    }

    private void OnRemoveItemClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var cartItem = button?.CommandParameter as CartItemModel;
        if (cartItem != null)
        {
            CartItems.Remove(cartItem);
            Store.Cart.Remove(cartItem.Product); // remove from global cart
            UpdatePriceSummary();
        }
    }

    private void OnApplyCouponClicked(object sender, EventArgs e)
    {
        // Simple placeholder logic for coupon
        string coupon = CouponEntry.Text;
        if (!string.IsNullOrWhiteSpace(coupon))
        {
            DisplayAlert("Coupon Applied", $"Coupon '{coupon}' applied successfully!", "OK");
        }
    }

    private async void OnProceedToCheckoutClicked(object sender, EventArgs e)
    {
        if (CartItems.Count == 0)
        {
            await DisplayAlert("Empty Cart", "Your shopping cart is empty!", "OK");
            return;
        }

        await Navigation.PushAsync(new CheckoutPage());
    }

    private void UpdatePriceSummary()
    {
        decimal subtotal = CartItems.Sum(ci => ci.Product.Price * ci.Quantity);
        decimal shipping = subtotal > 0 ? 20 : 0; // example shipping logic
        decimal total = subtotal + shipping;

        SubtotalLabel.Text = $"Subtotal: ${subtotal:F2}";
        ShippingLabel.Text = $"Shipping: ${shipping:F2}";
        TotalLabel.Text = $"Total: ${total:F2}";
    }
}
