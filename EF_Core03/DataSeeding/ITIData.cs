using EF_Core03.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.DataSeeding
{
    public class ITIData
    {
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }
        public List<Topic> Topics { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
