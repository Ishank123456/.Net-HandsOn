using Wipro_API_DFA_ProductService.EntityFramework;
using Wipro_API_DFA_ProductService.Models;

namespace Wipro_API_DFA_ProductService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WiproDfa26082024Context productDbContext;
        public ProductRepository(WiproDfa26082024Context _productDbContext)
        {
            productDbContext = _productDbContext;
        }
        public Product CreateProduct(Product product)
        {
            var result = productDbContext.Products.Add(product);
            productDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteProduct(int productId)
        {
            var filterProductData = productDbContext.Products.Where(p => p.Id == productId).FirstOrDefault();
            var result = productDbContext.Products.Remove(filterProductData);
            productDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productDbContext.Products.ToList();
        }

        public Product SearchProduct(int productId)
        {
            return productDbContext.Products.SingleOrDefault(p => p.Id == productId);
        }

        public Product UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = productDbContext.Products.Update(product);
            productDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
