using Wipro_API_ProductService.Model;

namespace Wipro_API_ProductService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product SearchProducts(int id);

        int CreateProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(Product product);
    }
}
