using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_ProductService.Model;
using Wipro_API_ProductService.Repository;

namespace Wipro_API_ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        [HttpPost("CreateProduct")]
        public ActionResult CreateProduct(Product product)
        {
            return Ok(productRepository.CreateProduct(product));
        }

        [HttpGet("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            return Ok(productRepository.GetAllProducts());
        }

        [HttpGet("SearchProductById")]
        public ActionResult SearchProducts(int productId)
        {
            return Ok(productRepository.SearchProducts(productId));
        }

        [HttpPut("UpdateProduct")]
        public ActionResult UpdateProduct(Product product)
        {
            return Ok(productRepository.UpdateProduct(product));
        }

        [HttpDelete("DeleteProduct")]
        public ActionResult DeleteProduct(Product product)
        {
            return Ok(productRepository.DeleteProduct(product));
        }
    }
}
