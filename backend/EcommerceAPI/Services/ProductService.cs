using ECommerceAPI.Models;  // Make sure this is the correct namespace for Product

namespace ECommerceAPI.Services
{
    public class ProductServices
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "Gaming Laptop", Price = 1200.00m, ImageUrl = "https://i5.walmartimages.com/asr/35b47efa-88ba-46ab-9faa-71096e67aed7.a7275eab204a8d8dc3d7949f0dbe74cc.jpeg" },
            new Product { Id = 2, Name = "Smartphone", Description = "High-end smartphone", Price = 800.00m, ImageUrl = "https://www.pngitem.com/pimgs/m/525-5259250_apple-ios-13-iphone-hd-png-download-apple.png" },
            new Product { Id = 3, Name = "Headphones", Description = "Noise Cancelling Headphones", Price = 150.00m, ImageUrl = "https://th.bing.com/th/id/OIP.Y2lv2Xc7bYRgsR2xkw5DbwHaH0?rs=1&pid=ImgDetMain" }
        };

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
