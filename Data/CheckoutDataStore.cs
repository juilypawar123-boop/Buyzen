using System.Collections.ObjectModel;
using Buyzen.Models;

namespace Buyzen.Data
{
    public static class CheckoutDataStore
    {
        public static ObservableCollection<CheckoutModel> Orders { get; set; }
            = new ObservableCollection<CheckoutModel>();

        // Sample addresses and delivery methods
        public static ObservableCollection<string> Addresses { get; set; }
            = new ObservableCollection<string> { "Home - 123 Main St", "Office - 456 Market St" };

        public static ObservableCollection<string> DeliveryMethods { get; set; }
            = new ObservableCollection<string> { "Standard Delivery", "Express Delivery", "Next-Day Delivery" };
    }
}
