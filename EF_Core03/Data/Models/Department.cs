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
        
        public virtual DateOnly HiringDate { get; set; }
        public virtual ICollection<Student>? DepartmentStudents { get; set; } = new List<Student>();

        public int? MangerId { get; set; }

        public virtual Instructor Manager { get; set; }
        public virtual ICollection<Instructor> instructors { get; set; } =new List<Instructor>();

    }
}
