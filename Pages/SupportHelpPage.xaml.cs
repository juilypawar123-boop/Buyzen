using Microsoft.Maui.Controls;
using Buyzen.Data;
using Buyzen.Models;
using System;
using System.Collections.ObjectModel;

namespace Buyzen.Pages
{
    public partial class SupportHelpPage : ContentPage
    {
        public ObservableCollection<SupportTicketModel> Tickets { get; set; }

        public SupportHelpPage()
        {
            InitializeComponent();

            Tickets = SupportTicketDataStore.Tickets;
            TicketHistoryView.ItemsSource = Tickets;
        }

        private void OnFaqSearchChanged(object sender, TextChangedEventArgs e)
        {
            // TODO: Implement FAQ filtering logic
        }

        private async void OnCreateTicketClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IssueDescriptionEditor.Text))
            {
                await DisplayAlert("Error", "Please enter an issue description.", "OK");
                return;
            }

            if (IssueCategoryPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please select a category.", "OK");
                return;
            }

            var ticket = new SupportTicketModel
            {
                Title = "Support Ticket Raised",
                Status = "Live",
                Category = IssueCategoryPicker.SelectedItem.ToString(),
                Description = IssueDescriptionEditor.Text
            };

            Tickets.Add(ticket);

            // Reset inputs
            IssueDescriptionEditor.Text = string.Empty;
            IssueCategoryPicker.SelectedIndex = -1;

            await DisplayAlert("Ticket Created", "Your support ticket has been created.", "OK");
        }
    }
}
