using ECommerceAPI.Models;  // Make sure this is the correct namespace for Product

namespace ECommerceAPI.Services
{
    public class ProductServices
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "Gaming Laptop", Price = 1200.00m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 2, Name = "Smartphone", Description = "High-end smartphone", Price = 800.00m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 3, Name = "Headphones", Description = "Noise Cancelling Headphones", Price = 150.00m, ImageUrl = "https://via.placeholder.com/150" }
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
