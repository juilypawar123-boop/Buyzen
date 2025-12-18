using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace Buyzen.Pages
{
    public partial class SalesAnalyticsPage : ContentPage
    {
        public SalesAnalyticsPage()
        {
            InitializeComponent();
            LoadAnalyticsData();
        }

        private void LoadAnalyticsData()
        {
            // Simulated analytics data
            RevenueLabel.Text = "Total Revenue: $124,500";
            ConversionLabel.Text = "Conversion Rate: 4.8%";

            TopProductsView.ItemsSource = new List<string>
            {
                "Laptop Pro X – 320 units",
                "Wireless Headphones – 275 units",
                "Smart Watch – 190 units",
                "Mechanical Keyboard – 160 units"
            };
        }

        private async void OnChangeRangeClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Date Range Updated",
                $"Analytics updated for: {DateRangePicker.SelectedItem}",
                "OK"
            );

            // Future: reload analytics from datastore/API
        }

        private async void OnExportReportClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Export Complete",
                "Sales report exported successfully.",
                "OK"
            );
        }

        private async void OnDrillDownClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Drill-Down",
                "Detailed analytics view coming soon.",
                "OK"
            );
        }
    }
}
