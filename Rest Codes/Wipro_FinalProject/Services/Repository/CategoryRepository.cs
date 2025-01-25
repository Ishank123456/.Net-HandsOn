using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_FinalProject.Models;

namespace Services.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int CreateCategory(Category category)
        {
            applicationDbContext.Categories.Add(category);
            return applicationDbContext.SaveChanges();
        }

        public int DeleteCategory(int id)
        {
            var category = applicationDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
            applicationDbContext.Categories.Remove(category);
            return applicationDbContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return applicationDbContext.Categories.ToList();
        }

        public Category SearchCategory(int id)
        {
            return applicationDbContext.Categories.SingleOrDefault(c => c.CategoryId == id);
        }

        public int UpdateCategory(Category category)
        {
            applicationDbContext.Categories.Update(category);
            return applicationDbContext.SaveChanges();
        }
    }
}
