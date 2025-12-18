using Microsoft.Maui.Controls;
using Buyzen.Models;
using System;
using System.Collections.ObjectModel;

namespace Buyzen.Pages
{
    public partial class OrderManagementPage : ContentPage
    {
        private ObservableCollection<OrderModel> Orders;

        public OrderManagementPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            StatusFilterPicker.ItemsSource = new[]
            {
                "All", "Pending", "Processing", "Shipped", "Delivered", "Cancelled"
            };

            OrderStatusPicker.ItemsSource = new[]
            {
                "Pending", "Processing", "Shipped", "Delivered", "Cancelled"
            };

            Orders = new ObservableCollection<OrderModel>
            {
                new OrderModel
                {
                    OrderId = "ORD-1001",
                    CustomerName = "Alice Johnson",
                    Status = "Pending",
                    TotalAmount = 249.99m
                },
                new OrderModel
                {
                    OrderId = "ORD-1002",
                    CustomerName = "Mark Smith",
                    Status = "Shipped",
                    TotalAmount = 499.00m
                }
            };

            OrdersView.ItemsSource = Orders;
        }

        private async void OnChangeStatusClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Status Updated", "Order status has been updated.", "OK");
        }

        private async void OnRefundClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Refund Issued", "Refund processed successfully.", "OK");
        }

        private async void OnFlagOrderClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Order Flagged", "Order has been flagged for review.", "OK");
        }
    }
}
