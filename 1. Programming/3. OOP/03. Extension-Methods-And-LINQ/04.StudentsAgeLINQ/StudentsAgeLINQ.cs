namespace StudentsAgeLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentClass; //Reference to StudentClass

    class StudentsAgeLINQ
    {
        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        static void FindStudentsBetweenAge()
        {
            var studentsBetweenAgeLinq =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            PrintStudents(studentsBetweenAgeLinq);
        }

        static List<Student> students;

        static void Main()
        {
            students = new List<Student>(){new Student("Hristo","Stefanov",26),
                                           new Student("Zara","Todorova",20),
                                           new Student("Angel","Sheiretov",21),
                                           new Student("Stoqn","Matev",10),
                                           new Student("Dobrin","Angelov",50),
                                           new Student("Marin","Petrov",18)};

            FindStudentsBetweenAge();
        }
    }
}
