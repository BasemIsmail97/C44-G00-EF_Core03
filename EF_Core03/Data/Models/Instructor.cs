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
        public decimal HourRateBouns {  get; set; }
        public ICollection<Course_Instructor> course_Instructors { get; set; } = new List<Course_Instructor>();
       
        public Department? MangeDepartment { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
