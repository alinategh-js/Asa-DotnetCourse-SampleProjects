using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.Domain
{

    public class Student
    {
        public Student()
        {

        }
        private Student(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
        public int Id { get; set; }
        public string Name { get; private set; }        
        public DateTime BirthDate { get; private set; }
        public int TeacherId { get; set; }
        public virtual ICollection<StudentCourse> Courses { get; set; }
    }
}
