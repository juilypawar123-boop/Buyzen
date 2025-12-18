using Buyzen.Models;
using System.Collections.ObjectModel;


namespace Buyzen.Data
{
    public static class UserProfileDataStore
    {
        public static ObservableCollection<AddressModel> Addresses { get; }
        = new ObservableCollection<AddressModel>();


        public static ObservableCollection<PaymentMethodModel> PaymentMethods { get; }
        = new ObservableCollection<PaymentMethodModel>();


        public static CommunicationPreferencesModel Preferences { get; set; }
        = new CommunicationPreferencesModel
        {
            EmailNotifications = true,
            SmsNotifications = false
        };
    }
}