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
    public class CourseInstructorEntityTypeConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(ci => new { ci.CourseId, ci.InstructorId });
            builder.Property(ci => ci.CourseId).IsRequired();
            builder.Property(ci => ci.InstructorId).IsRequired();
            builder.HasOne(ci => ci.Instructor).WithMany(i => i.course_Instructors).HasForeignKey(ci => ci.InstructorId);
            builder.HasOne(ci => ci.Course).WithMany(c => c.course_Instructors).HasForeignKey(ci => ci.CourseId);
        }
    }
    
    
}
