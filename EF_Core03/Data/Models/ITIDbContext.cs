using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_Core03.Data.Models
{
    public class ITIDbContext : Microsoft.EntityFrameworkCore.DbContext

    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_connection=true;Trustservercertificate=true");
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Student Class Configuration
            modelBuilder.Entity<Student>().ToTable("Students");
            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            #endregion

            #region Department Class Configuration
            modelBuilder.Entity<Department>().ToTable("Departments",D=>D.HasCheckConstraint("CK_Department_Hiringdate", "[HiringDate] <=GETDATE()"));
            new DepartmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Department>());
            #endregion

            #region Cours Class Configuration
            modelBuilder.Entity<Course>().ToTable("Courses", C => C.HasCheckConstraint("CK_Course_Duration", "[Duration]>0"));
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            #endregion

            #region Instructor Class Configuration 
            modelBuilder.Entity<Instructor>().ToTable("Instructors", I => I.HasCheckConstraint("CK_Istructor_HourRateBounsAndSalary", "[HourRateBouns]>=0 AND [Salary]>0"));
           
            new InstructorEntityTypeConfiguration().Configure(modelBuilder.Entity<Instructor>());


            #endregion

            #region Topic class Configuration
            modelBuilder.Entity<Topic>().ToTable("Topics");
            new TopicEntityTypeConfiguration().Configure(modelBuilder.Entity<Topic>());

            #endregion

            #region Stud_Course Class Configuration
            modelBuilder.Entity<StudentCourse>().ToTable("Stud_Courses");
            new StudentCourseEntityTypeConfiguration().Configure(modelBuilder.Entity<StudentCourse>());
            #endregion


            #region Course_Inst Class Configuration

            modelBuilder.Entity<Course_Instructor>().ToTable("Course_Instructors");
            new Course_IstructorEntityTypeConfiguration().Configure(modelBuilder.Entity<Course_Instructor>());
            #endregion


        }
    }
}
