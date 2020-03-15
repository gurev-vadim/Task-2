using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_Task
{
    class LINQ
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name="Ger",  Age=21, Faculty=3},
                new Student{Name="Sir",  Age=25, Faculty=1},
                new Student{Name="Pit",  Age=19, Faculty=4},
                new Student{Name="Paul", Age=27, Faculty=3},
                new Student{Name="Jack", Age=18, Faculty=5}
            };

            //Сортировка по возрасту
            var selectedStudents = from student in students
                                       //where student.Age > 24
                                   where student.Age > 24 && student.Faculty > 2
                                   select student;
            foreach (Student student in selectedStudents)
                Console.WriteLine($"Name:{student.Name} Age:{student.Age} Faculty:{student.Faculty}\n");

            //Группировка по факультету
            var studentGroups = from student in students
                              group student by student.Faculty;
            foreach (IGrouping<int, Student> g in studentGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
