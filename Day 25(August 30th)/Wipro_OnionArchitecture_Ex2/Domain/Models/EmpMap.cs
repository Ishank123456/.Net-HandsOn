using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmpMap
    {
        public EmpMap(EntityTypeBuilder<Employee> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.EmpId);
            entityTypeBuilder.Property(e => e.EmpName).IsRequired();
            entityTypeBuilder.Property(e => e.EmpSal).IsRequired();
            entityTypeBuilder.Property(e => e.EmpCity).IsRequired();
            entityTypeBuilder.Property(e => e.EmpCity).HasMaxLength(20);
            entityTypeBuilder.Property(e => e.EmpGender).IsRequired();
            entityTypeBuilder.Property(e => e.EmpGender).HasMaxLength(10);


        }
    }
}
