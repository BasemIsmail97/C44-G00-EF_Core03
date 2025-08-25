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
    public class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(C => C.Duration).IsRequired();
            builder.Property(C=>C.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(C=>C.Description).HasColumnType("nvarchar(255)");
            builder.HasOne(C=>C.Topic).WithMany(T=>T.Courses).HasForeignKey(C=>C.TopicId);
            builder.Property(C=>C.TopicId).IsRequired();
            builder.HasIndex(C=>C.Name).IsUnique();

        }
    }
}
