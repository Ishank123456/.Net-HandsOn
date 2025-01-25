using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_FinalProject.Models;

namespace Services.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProductRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public List<Product> GetProducts()
        {
            return applicationDbContext.Products.ToList();
        }

        public Product SearchProducts(int id)
        {
            return applicationDbContext.Products.SingleOrDefault(p => p.ProductId == id);
        }
    }
}
