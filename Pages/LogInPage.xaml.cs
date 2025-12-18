using Buyzen.Data;
using Buyzen.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;
using System.Threading.Tasks;

namespace Buyzen.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Login button click
        private void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text ?? string.Empty;
            string password = PasswordEntry.Text ?? string.Empty;

            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                SetLoggedInState(email);
            }
            else
            {
                DisplayAlert("Login Failed", "Please enter both email and password.", "OK");
            }
        }

        // Logout button click
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Logout", "Are you sure you want to log out?", "Yes", "Cancel");
            if (confirm)
            {
                Preferences.Set("IsLoggedIn", false);
                Preferences.Remove("LoggedInUser");
                SetLoggedOutState();
            }
        }

        // Restore login state when page appears
        protected override void OnAppearing()
        {
            base.OnAppearing();

            bool isLoggedIn = Preferences.Get("IsLoggedIn", false);
            string email = Preferences.Get("LoggedInUser", "");

            if (isLoggedIn && !string.IsNullOrEmpty(email))
            {
                SetLoggedInState(email);
            }
            else
            {
                SetLoggedOutState();
            }
        }

        // Enable buttons and show welcome message
        private void SetLoggedInState(string email)
        {
            CartButton.IsEnabled = true;
            WishlistButton.IsEnabled = true;
            OrdersButton.IsEnabled = true;
            ReturnsButton.IsEnabled = true;
            CheckoutOrdersButton.IsEnabled = true;
            LogoutButton.IsEnabled = true;
            UserProfileButton.IsEnabled = true;
            SupportandHelpButton.IsEnabled = true;
            ManagementButton.IsEnabled = true;
            OrdermanagementButton.IsEnabled = true;
            SalesAnalyticsButton.IsEnabled = true;

            Preferences.Set("IsLoggedIn", true);
            Preferences.Set("LoggedInUser", email);

            CenterContent.Content = new Label
            {
                Text = $"Welcome, {email}! Please select an option from the right.",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }

        // Disable buttons and show login prompt
        private void SetLoggedOutState()
        {
            CartButton.IsEnabled = false;
            WishlistButton.IsEnabled = false;
            OrdersButton.IsEnabled = false;
            ReturnsButton.IsEnabled = false;
            CheckoutOrdersButton.IsEnabled = false;
            LogoutButton.IsEnabled = false;
            UserProfileButton.IsEnabled = false;
            SupportandHelpButton.IsEnabled = false;
            ManagementButton.IsEnabled = false;
            OrdermanagementButton.IsEnabled = false;
            SalesAnalyticsButton.IsEnabled = false;

            CenterContent.Content = new Label
            {
                Text = "You are logged out. Please log in to access your account.",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
        private async void OnCheckoutOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckoutPage());
        }
        private async void OnProductManagementClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductManagementPage());
        }
        private async void OnOderManagementClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderManagementPage());
        }
        private async void OnSalesandAnalyticsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalesAnalyticsPage());
        }
        private async void OnCartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingCartPage());
        }
        private async void OnWishlistClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WishlistPage());
        }
        private async void OnOrdersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderSummaryPage());
        }
        private async void OnReturnsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReturnsRefundsPage());
        }
        private async void OnUserprofileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserProfilePage());
        }
        private async void OnsupporthelpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupportHelpPage());
        }

    }


}