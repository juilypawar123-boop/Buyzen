using Microsoft.Maui.Controls;
using Buyzen.Data;
using Buyzen.Models;
using System;
using System.Collections.Generic;

namespace Buyzen.Pages
{
    public partial class CheckoutPage : ContentPage
    {
        private CheckoutModel CurrentOrder;

        public CheckoutPage()
        {
            InitializeComponent();

            AddressPicker.ItemsSource = CheckoutDataStore.Addresses;
            DeliveryMethodPicker.ItemsSource = CheckoutDataStore.DeliveryMethods;

            InitializeOrder();
        }

        private void InitializeOrder()
        {
            CurrentOrder = new CheckoutModel
            {
                Items = new List<string>
                {
                    "Laptop - $999",
                    "Mouse - $25",
                    "Keyboard - $50"
                },
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

        private async void OnPlaceOrderClicked(object sender, EventArgs e)
        {
            if (AddressPicker.SelectedItem is null)
            {
                await DisplayAlert("Error", "Please select an address.", "OK");
                return;
            }

            if (DeliveryMethodPicker.SelectedItem is null)
            {
                await DisplayAlert("Error", "Please select a delivery method.", "OK");
                return;
            }

            CurrentOrder.SelectedAddress = AddressPicker.SelectedItem.ToString()!;
            CurrentOrder.DeliveryMethod = DeliveryMethodPicker.SelectedItem.ToString()!;

            CheckoutDataStore.Orders.Add(CurrentOrder);

            await DisplayAlert(
                "Order Placed",
                $"Your order has been placed successfully.\nTotal: ${CurrentOrder.Total:F2}",
                "OK"
            );

            AddressPicker.SelectedIndex = -1;
            DeliveryMethodPicker.SelectedIndex = -1;

            InitializeOrder();
        }

        private async void OnCancelCheckoutClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert(
                "Cancel Checkout",
                "Are you sure you want to cancel?",
                "Yes",
                "No"
            );

            if (confirm)
            {
                AddressPicker.SelectedIndex = -1;
                DeliveryMethodPicker.SelectedIndex = -1;
            }
        }

        private async void OnEditAddressClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Edit Address",
                "Address editing will be available soon.",
                "OK"
            );
        }

        private async void OnChangeDeliveryClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Change Delivery",
                "Select a different delivery option above.",
                "OK"
            );
        }
    }
}
