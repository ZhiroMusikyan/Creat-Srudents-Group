using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email { get; set; }
        public string Fullname
        {
            get { return $"{Name} {Surname}"; }
        }
        public byte Age { get; set; }
    }
}
