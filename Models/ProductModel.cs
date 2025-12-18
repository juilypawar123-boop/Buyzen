using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyzen.Models; 
public class Product
{
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Category { get; set; }

    public int Stock { get; set; }
    public bool IsVisible { get; set; } = true;

    public string StockStatus =>
        Stock == 0 ? "Out of Stock" :
        Stock < 5 ? "Low Stock" : "In Stock";

    public Color StockColor =>
        Stock == 0 ? Colors.Red :
        Stock < 5 ? Colors.Orange : Colors.LightGreen;
}
