using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class Course
    {

        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public virtual ICollection<CourseInstructor> course_Instructors { get; set; } = new List<CourseInstructor>();
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
