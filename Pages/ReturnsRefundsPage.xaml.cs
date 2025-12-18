using Microsoft.Maui.Controls;
using Buyzen.Models;
using Buyzen.Data;
using System;
using System.Collections.ObjectModel;

namespace Buyzen.Pages
{
    public partial class ReturnsRefundsPage : ContentPage
    {
        public ObservableCollection<Product> EligibleItems { get; set; } = new ObservableCollection<Product>();

        public ReturnsRefundsPage()
        {
            InitializeComponent();

            // Sample items eligible for return
            EligibleItems.Add(new Product { Name = "Laptop", Price = 999 });
            EligibleItems.Add(new Product { Name = "Headphones", Price = 150 });
            EligibleItems.Add(new Product { Name = "Keyboard", Price = 50 });

            EligibleItemsView.ItemsSource = EligibleItems;
        }

        private async void OnRequestReturnClicked(object sender, EventArgs e)
        {
            if (ReturnReasonPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please select a return reason.", "OK");
                return;
            }

            await DisplayAlert("Return Requested", $"Your return request has been submitted for reason: {ReturnReasonPicker.SelectedItem}", "OK");
        }

        private async void OnCancelReturnClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Cancel Return", "Are you sure you want to cancel this return request?", "Yes", "No");
            if (confirm)
            {
                await DisplayAlert("Cancelled", "Return request has been cancelled.", "OK");
            }
        }

        private async void OnTrackRefundClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Refund Status", "Your refund is being processed. Expected within 5 business days.", "OK");
        }

        private async void OnUploadEvidenceClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Upload", "Feature to upload evidence will be implemented in future updates.", "OK");
        }
    }
}
