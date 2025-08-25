using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FName).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.LName).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Address).HasColumnType("nvarchar(150)").IsRequired(false);
            builder.Property(x => x.Age).IsRequired();
            builder.HasOne(s => s.Department).WithMany(d => d.DepartmentStudents).HasForeignKey(s => s.DepartmentId);
            builder.Property(s => s.DepartmentId).IsRequired();

        }
    }
}
