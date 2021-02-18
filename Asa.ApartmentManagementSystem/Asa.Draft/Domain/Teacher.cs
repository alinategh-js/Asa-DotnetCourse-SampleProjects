using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.Domain
{
    public class Teacher
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual List<Student> Students { get; private set; }

    }
}
