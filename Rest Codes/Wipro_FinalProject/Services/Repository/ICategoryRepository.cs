using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_FinalProject.Models;

namespace Services.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category SearchCategory(int id);
        int CreateCategory (Category category);
        int UpdateCategory (Category category);
        int DeleteCategory (int id);
    }
}
