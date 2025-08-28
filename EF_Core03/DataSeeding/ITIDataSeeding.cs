using EF_Core03.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.Json;

namespace EF_Core03.DataSeeding
{
    public static class ITIDataSeeding
    {
       
        public static bool DataSeeding(ITIDbContext ITIDbContext)
        {
            try
            {
                
                #region Department
                if (!ITIDbContext.Departments.Any())
                {
                    var DepartmentsData = File.ReadAllText("file\\Department.json");

                    var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);
                    if (Departments?.Count > 0)
                    {
                        ITIDbContext.AddRange(Departments);
                        ITIDbContext.SaveChanges();
                        
                    }

                   
                 }
                #endregion
                #region Student
                if (!ITIDbContext.Students.Any())
                {
                    var StudensData = File.ReadAllText("file\\Student.json");

                    var Studens = JsonSerializer.Deserialize<List<Student>>(StudensData);
                    if (Studens?.Count > 0)
                    {
                        ITIDbContext.AddRange(Studens);
                        ITIDbContext.SaveChanges();
                        
                    }
                  
                }
                #endregion
                #region Topic
                if (!ITIDbContext.Topics.Any())
                {
                    var TopicsData = File.ReadAllText("file\\Topic.json");

                    var Topics = JsonSerializer.Deserialize<List<Topic>>(TopicsData);
                    if (Topics?.Count > 0)
                    {
                        ITIDbContext.AddRange(Topics);
                        ITIDbContext.SaveChanges();
                        
                    }
                    return true;
                }
                #endregion
                #region Course
                if (!ITIDbContext.Courses.Any())
                {
                    var CoursesData = File.ReadAllText("file\\Course.json");
                    var Courses = JsonSerializer.Deserialize<List<Course>>(CoursesData);
                    if (Courses?.Count > 0)
                    {
                        ITIDbContext.AddRange(Courses);
                        ITIDbContext.SaveChanges();
                        
                    }

                }



                #endregion
                #region Instructor

                if (!ITIDbContext.Instructors.Any())
                {
                    var InstructorsData = File.ReadAllText("file\\Instructor.json");
                    var Instructors = JsonSerializer.Deserialize<List<Instructor>>(InstructorsData);
                    if (Instructors?.Count > 0)
                    {
                        ITIDbContext.AddRange(Instructors);
                        ITIDbContext.SaveChanges();
                        
                    }
                }
                #endregion
                #region StudentCourse

                if (!ITIDbContext.StudentCourses.Any())
                {
                    var StudentCoursesData = File.ReadAllText("file\\StudentCourse.json");
                    var StudentCourses = JsonSerializer.Deserialize<List<StudentCourse>>(StudentCoursesData);
                    if (StudentCourses?.Count > 0)
                    {
                        ITIDbContext.AddRange(StudentCourses);
                        ITIDbContext.SaveChanges();
                        
                    }
                }
                #endregion
                #region CourseInstructor

                if (!ITIDbContext.CourseInstructors.Any())
                {
                    var CourseInstructorsData = File.ReadAllText("file\\CourseInstructor.json");
                    var CourseInstructors = JsonSerializer.Deserialize<List<CourseInstructor>>(CourseInstructorsData);
                    if (CourseInstructors?.Count > 0)
                    {
                        ITIDbContext.AddRange(CourseInstructors);
                        ITIDbContext.SaveChanges();
                        
                    }
                }
                #endregion
                return true;
            }
            catch 
            {
             
                return false;


            }
        }
    }
}
