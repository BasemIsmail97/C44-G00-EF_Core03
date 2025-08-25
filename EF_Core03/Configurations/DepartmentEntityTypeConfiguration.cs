using EF_Core03.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Configurations
{
    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.HasKey(D => D.Id);
            builder.Property(D => D.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.HasIndex(D=> D.Name).IsUnique();
            builder.Property(D=>D.HiringDate).IsRequired();
            builder.HasOne(D=>D.Manager).WithOne(I=>I.ManageDepartment).HasForeignKey<Department>(D=>D.MangerId);

        }
    }
}
