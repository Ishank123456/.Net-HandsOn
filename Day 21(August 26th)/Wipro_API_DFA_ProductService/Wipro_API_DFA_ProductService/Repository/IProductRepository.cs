using Wipro_API_DFA_ProductService.Models;

namespace Wipro_API_DFA_ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product SearchProduct(int productId);
        Product CreateProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int productId);
    }
}
