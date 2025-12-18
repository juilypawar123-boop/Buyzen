using System;

namespace Buyzen.Models
{
    public class OrderModel
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
