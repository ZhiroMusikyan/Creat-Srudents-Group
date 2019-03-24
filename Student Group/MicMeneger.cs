using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group
{
    class MicMeneger
    {
        public List<Group> groups(Teacher[] teachers, Student[] students, string cours)
        {
            int n = students.Length;
            int groupCount = teachers.Length;
            int quotient = n / groupCount;
            int remainder = n % groupCount;
            int count = 0;
            List<Group> groups = new List<Group>(teachers.Length);

            for (int i = 0; i < groupCount; i++)
            {
                List<Student> stu = new List<Student>();
            if (remainder > 0)
            {
                for (int j = 0; j < quotient + 1; j++)
                {
                    stu.Add(students[count]);
                    count++;
                }
            }
            else
            {
                for (int j = 0; j < quotient; j++)
                {
                    stu.Add(students[count]);
                    count++;
                }
            }


           
                Group group = new Group();
                group.Cours = cours;
                group.Teacher = teachers[i];
                group.Students = stu;
                groups.Add(group);

                remainder--;
            }
            return groups;
        }

        public void Shaffle(Student[] stu)
        {
            int n = stu.Length;
            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int x = i + rnd.Next(n - i);
                Swap(stu, i,x );
            }
        }


        private void Swap(Student[] stu, int a, int b)
        {
            Student temp = stu[a];
            stu[a] = stu[b];
            stu[b] = temp;
        }
    }
}
