using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group
{
    class Creator
    {
        public Student[]CreatStudent(int count)
        {
            var rnd = new Random();
            Student[] students = new Student[count];

            for (int i = 0; i < students.Length; i++)
            {
                Student stu = new Student();
                stu.Age = (byte)rnd.Next(16, 43);
                stu.Email = $"S{1 + i}.com";
                stu.Name= $"S{1 + i}";
                stu.Surname = $"S{1 + i}yan";
                students[i] = stu;
            }

            return students;
        }

        public Teacher[]CreaTeacher(int count)
        {
            var rnd = new Random();
           Teacher[]teachers = new Teacher[count];

            for (int i = 0; i < teachers.Length; i++)
            {
                Teacher T = new Teacher();
                T.Email = $"T{1 + i}.com";
                T.Name = $"T{1 + i}";
                T.Surname = $"T{1 + i}yan";
                teachers[i]=T;
            }

            return teachers;
        }
    }
}
