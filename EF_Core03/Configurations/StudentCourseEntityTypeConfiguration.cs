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
    public class StudentCourseEntityTypeConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Property(sc=>sc.StudentId).IsRequired();
            builder.Property(sc=>sc.CourseId).IsRequired();
            builder.HasOne(sc=>sc.Student).WithMany(s=>s.StudentCourses).HasForeignKey(sc=>sc.StudentId);
            builder.HasOne(sc=>sc.Course).WithMany(c=>c.StudentCourses).HasForeignKey(sc=>sc.CourseId);
        }
    }
}
