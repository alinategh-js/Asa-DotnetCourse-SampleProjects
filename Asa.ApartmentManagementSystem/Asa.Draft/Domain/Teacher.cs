using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.Domain
{
    public class Teacher
    {
        public Teacher()
        {
            _students = new List<Student>();
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        List<Student> _students;
        public IEnumerable<Student> Students => _students.AsReadOnly();

    }
}
