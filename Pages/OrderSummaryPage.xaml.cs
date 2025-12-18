using Microsoft.Maui.Controls;
using Buyzen.Data;
using Buyzen.Models;
using System;
using System.Collections.Generic;

namespace Buyzen.Pages
{
    public partial class OrderSummaryPage : ContentPage
    {
        private CheckoutModel CurrentOrder { get; set; }

        public OrderSummaryPage()
        {
            InitializeComponent();

            // Load pickers
            AddressPicker.ItemsSource = CheckoutDataStore.Addresses;
            DeliveryMethodPicker.ItemsSource = CheckoutDataStore.DeliveryMethods;

            // Sample order
            CurrentOrder = new CheckoutModel
            {
                Items = new List<string> { "Laptop - $999", "Mouse - $25", "Keyboard - $50" },
                Subtotal = 1074m,
                Tax = 86m
            };

            OrderItemsView.ItemsSource = CurrentOrder.Items;
            UpdateSummaryLabels();
        }

        private void UpdateSummaryLabels()
        {
            SubtotalLabel.Text = $"Subtotal: ${CurrentOrder.Subtotal:F2}";
            TaxLabel.Text = $"Tax: ${CurrentOrder.Tax:F2}";
            TotalLabel.Text = $"Total: ${CurrentOrder.Total:F2}";
        }

        private async void OnRefreshStatusClicked(object sender, EventArgs e)
        {
            // Simulate status update
            OrderStatusLabel.Text = "Order Shipped";
            OrderProgressBar.Progress = 0.66;
            DeliveryETA.Text = "Estimated Delivery: 1 day";
            await DisplayAlert("Status Updated", "Order status refreshed.", "OK");
        }

        private async void OnContactSupportClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Support", "Contact support at support@buyzen.com", "OK");
        }

        private async void OnDownloadInvoiceClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Invoice", "Invoice download feature will be available soon.", "OK");
        }

        private async void OnReportIssueClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Report Issue", "Redirecting to Support & Help page.", "OK");
        }

        private async void OnPlaceOrderClicked(object sender, EventArgs e)
        {
            if (AddressPicker.SelectedIndex == -1 || DeliveryMethodPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please select address and delivery method.", "OK");
                return;
            }

            CurrentOrder.SelectedAddress = AddressPicker.SelectedItem.ToString();
            CurrentOrder.DeliveryMethod = DeliveryMethodPicker.SelectedItem.ToString();
            CheckoutDataStore.Orders.Add(CurrentOrder);

            await DisplayAlert("Order Placed", $"Your order has been placed!\nTotal: ${CurrentOrder.Total:F2}", "OK");
        }

        private async void OnCancelCheckoutClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Cancel Checkout", "Are you sure you want to cancel?", "Yes", "No");
            if (confirm)
            {
                AddressPicker.SelectedIndex = -1;
                DeliveryMethodPicker.SelectedIndex = -1;
            }
        }
        
        private async void OnEditAddressClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Address", "Address update system coming soon", "OK");
        }
        private async void OnChangeDeliveryClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Delivery", "Change delivery options coming soon", "OK");
        }
    }
}
