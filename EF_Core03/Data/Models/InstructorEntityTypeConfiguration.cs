using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class InstructorEntityTypeConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
           builder.HasKey(I => I.Id);
            builder.Property(I => I.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(I => I.Address ).HasColumnType("nvarchar(150)");
            builder.Property(I => I.Salary).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(I => I.HourRateBouns).HasColumnType("decimal(10,2)").HasDefaultValue(0);
            builder.HasOne(I => I.Department).WithMany(D => D.instructors).HasForeignKey(I => I.DepartmentId);
            builder.Property(I=>I.DepartmentId).IsRequired();



        }
    }
}
