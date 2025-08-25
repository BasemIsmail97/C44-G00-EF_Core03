using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRateBonus {  get; set; }
        public ICollection<CourseInstructor> course_Instructors { get; set; } = new List<CourseInstructor>();
       
        public Department? ManageDepartment { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
