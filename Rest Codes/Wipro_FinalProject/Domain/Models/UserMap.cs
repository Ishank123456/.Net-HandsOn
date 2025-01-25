using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_FinalProject.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.Property(t => t.Email).IsRequired();

            entityTypeBuilder.HasOne(t => t.Profile).WithOne(u => u.User)
                .HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
