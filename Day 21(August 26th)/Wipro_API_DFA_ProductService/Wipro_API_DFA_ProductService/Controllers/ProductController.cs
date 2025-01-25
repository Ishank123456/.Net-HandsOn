using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_DFA_ProductService.Models;
using Wipro_API_DFA_ProductService.Repository;

namespace Wipro_API_DFA_ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository iProductRepository;
        public ProductController(IProductRepository _iProductRepository)
        {
            iProductRepository = _iProductRepository;
        }

        [HttpPost("CreateProduct")]
        public ActionResult CreateProduct(Product product)
        {
            return Ok(iProductRepository.CreateProduct(product));
        }

        [HttpGet("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            return Ok(iProductRepository.GetAllProducts());
        }

        [HttpGet("SearchProductById")]
        public ActionResult SearchProductById(int productId)
        {
            return Ok(iProductRepository.SearchProduct(productId));
        }

        [HttpPut("UpdateProductInfo")]
        public ActionResult UpdateProduct(Product product)
        {
            return Ok(iProductRepository.UpdateProduct(product));
        }

        [HttpDelete("DeleteProductInfo")]
        public ActionResult DeleteProduct(int productId)
        {
            return Ok(iProductRepository.DeleteProduct(productId));
        }
    }
}
