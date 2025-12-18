using System.Collections.ObjectModel;
using Buyzen.Models;

namespace Buyzen.Data
{
    public static class SupportTicketDataStore
    {
        public static ObservableCollection<SupportTicketModel> Tickets { get; set; }
            = new ObservableCollection<SupportTicketModel>();
    }
}
