using Microsoft.Maui.Controls;
using Buyzen.Data;
using Buyzen.Models;
using System;


namespace Buyzen.Pages
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
        }


        private async void OnAddAddressClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Address", "Add Address feature coming soon.", "OK");
        }


        private async void OnRemovePaymentClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Payment", "Remove Payment Method feature coming soon.", "OK");
        }
        private async void OnUpdatePreferencesClicked(object sender, EventArgs e)
        {
            string prefs = $"Email: {EmailSwitch.IsToggled}, SMS: {SmsSwitch.IsToggled}";
            await DisplayAlert("Preferences Updated", prefs, "OK");
        }
        private async void OnChangePasswordClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Security", "Change Password feature coming soon.", "OK");
        }
    }
}