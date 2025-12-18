using System;
using System.Collections.Generic;

namespace Buyzen.Models
{
    public class CheckoutModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? SelectedAddress { get; set; }
        public string? DeliveryMethod { get; set; }
        public List<string> Items { get; set; } = new();
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total => Subtotal + Tax;
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
