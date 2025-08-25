using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core03.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateOnly HiringDate { get; set; }
        public ICollection<Student>? DepartmentStudents { get; set; } = new List<Student>();

        public int? MangerId { get; set; }

        public Instructor Manager { get; set; }
        public ICollection<Instructor> instructors { get; set; } =new List<Instructor>();

    }
}
