using System;


namespace Buyzen.Models
{
    public class PaymentMethodModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CardHolderName { get; set; }
        public string Last4Digits { get; set; }
        public string CardType { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}