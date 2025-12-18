using Buyzen.Models;

namespace Buyzen.Models;

public class CartItemModel
{
    public Product Product { get; set; }
    public int Quantity { get; set; } = 1;

    public string Name => Product.Name;
    public string ShortDescription => Product.ShortDescription;
    public decimal Price => Product.Price;
    public string ImageUrl => Product.ImageUrl;
}
