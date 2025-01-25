using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DeptMap
    {
        public DeptMap(EntityTypeBuilder<Department> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(d => d.DeptId);
            entityTypeBuilder.Property(d => d.DeptName).IsRequired();

            //entityTypeBuilder.HasMany(e => e.Employees).WithOne(d => d.Department).HasForeignKey(e => e.EmpId);
        }
    }
}
