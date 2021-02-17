using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<StudentCourse> Students { get; set; }
    }
}
