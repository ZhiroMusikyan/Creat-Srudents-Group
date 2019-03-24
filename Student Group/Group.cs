using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group
{
    class Group
    {
        public string  Cours { get; set; }
        public Teacher Teacher { get; set; }
       public List<Student> Students { get; set; }
    }
}
