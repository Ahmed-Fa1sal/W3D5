using Microsoft.AspNetCore.Mvc;
using ECommerceAPI.Services;  
using ECommerceAPI.Models;    

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductServices _productService;

        // Constructor uses Dependency Injection to get ProductServices
        public ProductsController(ProductServices productService)
        {
            _productService = productService;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(_productService.GetProducts());
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
