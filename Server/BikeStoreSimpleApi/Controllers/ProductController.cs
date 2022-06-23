using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetAllProduct()
        {
            return _productService.GetAllProduct();
        }
        [HttpGet("{Id:int}")]
        public Product GetProductById(int Id)
        {
            return _productService.GetProductById(Id);
        }
        [HttpPost]
        public Product CreateProduct(Product model)
        {
            return _productService.CreateProduct(model);
        }
        [HttpPut]
        public Product UpdateProduct(Product model)
        {
            return _productService.UpdateProduct(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteProduct(int Id)
        {
            return _productService.DeleteProduct(Id);
        }
    }
}
