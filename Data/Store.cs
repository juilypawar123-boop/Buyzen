using Buyzen.Models;
using System.Collections.ObjectModel;

namespace Buyzen.Data
{
    public static class Store
    {
        // All available products
        public static ObservableCollection<Product> AllProducts { get; set; } = new ObservableCollection<Product>
        {
            new Product
            {
                Name = "Wireless Headphones",
                ShortDescription = "Noise-isolating over-ear headphones",
                Price = 79.99m,
                ImageUrl = "headphone.jpg",
                Category = "Electronics"
            },
            new Product
            {
                Name = "Running Shoes",
                ShortDescription = "Lightweight shoes for daily training",
                Price = 59.49m,
                ImageUrl = "shoes.jpg",
                Category = "Sports"
            },
            new Product
            {
                Name = "Laptop",
                ShortDescription = "High-performance laptop built for productivity, work, and entertainment",
                Price = 110m,
                ImageUrl = "laptop.jpg",
                Category = "Electronics"
            },
            new Product
            {
                Name = "Sofa",
                ShortDescription = "Comfortable multi-seater sofa designed for modern living spaces",
                Price = 59.49m,
                ImageUrl = "sofa.jpg",
                Category = "Home"
            },
            new Product
            {
                Name = "Camera",
                ShortDescription = "Compact digital camera delivering sharp images and clear video",
                Price = 70m,
                ImageUrl = "camera.jpg",
                Category = "Electronics"
            },
            new Product
            {
                Name = "Mobile",
                ShortDescription = "Smartphone with sleek design, fast performance, and advanced features",
                Price = 150m,
                ImageUrl = "android.jpg",
                Category = "Electronics"
            },
            new Product
            {
                Name = "Chair",
                ShortDescription = "Cozy chair for comfort and support.",
                Price = 45m,
                ImageUrl = "chair.jpg",
                Category = "Home"
            },
            new Product
            {
                Name = "Heels",
                ShortDescription = "Comfortable high heels for office use",
                Price = 130m,
                ImageUrl = "heels.png",
                Category = "Fashion"
            },
            new Product
            {
                Name = "Vintage Dress",
                ShortDescription = "Vintage dress perfect for vintage themed party",
                Price = 400m,
                ImageUrl = "vintagedress.png",
                Category = "Fashion"
            },
            new Product
            {
                Name = "Jacket",
                ShortDescription = "Comfortable & soft jacket",
                Price = 240m,
                ImageUrl = "jacket1.png",
                Category = "Fashion"
            },
            new Product
            {
                Name = "Sunglasses",
                ShortDescription = "Black sunglasses for summer",
                Price = 40m,
                ImageUrl = "sunglasses.png",
                Category = "Fashion"
            },
            new Product
            {
                Name = "Tennis Racket",
                ShortDescription = "Easy to hold & lightweight racket",
                Price = 80m,
                ImageUrl = "tennisracket.png",
                Category = "Sports"
            },
            new Product
            {
                Name = "Chess Board",
                ShortDescription = "Chess board in red color",
                Price = 30m,
                ImageUrl = "chessboard.png",
                Category = "Sports"
            },
            new Product
            {
                Name = "Interior",
                ShortDescription = "Amazing home decoration",
                Price = 120m,
                ImageUrl = "interior.jpg",
                Category = "Home"
            },
            new Product
            {
                Name = "Briefcase",
                ShortDescription = "Black briefcases and small handbags for formal use",
                Price = 100m,
                ImageUrl = "briefcase.png",
                Category = "Fashion"
            },
            new Product
            {
                Name = "Bicycle",
                ShortDescription = "Lightweight bicycle",
                Price = 250m,
                ImageUrl = "bicycle.png",
                Category = "Sports"
            },
            new Product
            {
                Name = "Vase",
                ShortDescription = "Decorative home vase",
                Price = 30m,
                ImageUrl = "vase.jpg",
                Category = "Home"
            },
            new Product
            {
                Name = "Birdcage",
                ShortDescription = "Showpiece birdcage",
                Price = 70m,
                ImageUrl = "birdcage.jpg",
                Category = "Home"
            }
        };

        public static ObservableCollection<Product> Cart { get; set; } = new ObservableCollection<Product>();
        public static ObservableCollection<Product> Wishlist { get; set; } = new ObservableCollection<Product>();
      
    }
}
