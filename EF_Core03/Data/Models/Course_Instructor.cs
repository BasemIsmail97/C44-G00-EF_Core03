using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class Course_Instructor
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        [Range(1, 10)]
        public int? Evaluate { get; set; }

    }
}
