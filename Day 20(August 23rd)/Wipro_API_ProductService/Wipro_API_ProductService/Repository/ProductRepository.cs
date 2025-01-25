using Wipro_API_ProductService.EntityFramework;
using Wipro_API_ProductService.Model;

namespace Wipro_API_ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext productDbContext;
        public ProductRepository(ProductDbContext _productDbContext)
        {
            productDbContext = _productDbContext;
        }

        public int CreateProduct(Product product)
        {
            productDbContext.Products.Add(product);
            return productDbContext.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productDbContext.Products.ToList();
        }

        public Product SearchProducts(int productId)
        {
            return productDbContext.Products.SingleOrDefault(t => t.ProductId == productId);
        }

        public int UpdateProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            productDbContext.Products.Update(product);
            return productDbContext.SaveChanges();
        }

        public int DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            productDbContext.Products.Remove(product);
            return productDbContext.SaveChanges();
        }
    }
}
