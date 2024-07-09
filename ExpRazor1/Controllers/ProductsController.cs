using ExpRazor1.Models;
using ExpRazor1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpRazor1.Controllers
{
    [Route("[controller]")]//remove "api."
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService) { 
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get() { 
            return ProductService.GetProducts();
        }
    }
}
