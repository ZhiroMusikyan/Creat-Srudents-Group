using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            string cours = "c#";
            Student[] students = creator.CreatStudent(23);
            Teacher[] teachers = creator.CreaTeacher(4);
            MicMeneger meneger = new MicMeneger();
            meneger.Shaffle(students);
            List<Group> groups = meneger.groups(teachers, students, cours);
            Print(groups);
            Console.WriteLine();
            Console.ReadLine();
        }
       static public void Print(List<Group> groups)
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"cours {item.Cours}");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine();
                Console.WriteLine($"Teacher full name is {item.Teacher.Fullname}");
                Console.WriteLine(new string('-', 8));

                for (int i = 0; i < item.Students.Count; i++)
                {
                    Console.WriteLine($"student ful name {item.Students[i].Fullname}");
                    Console.WriteLine($"Email {item.Students[i].Email}");
                    Console.WriteLine($"Age {item.Students[i].Age}\n");

                }
                Console.WriteLine();
            }
        }
    }
}
