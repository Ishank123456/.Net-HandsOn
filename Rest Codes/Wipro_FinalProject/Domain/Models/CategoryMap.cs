using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_FinalProject.Models
{
    public class CategoryMap
    {
        public CategoryMap(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.Property(t => t.CategoryName).IsRequired();

            entityTypeBuilder.HasMany(x => x.LstProduct)
                .WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
