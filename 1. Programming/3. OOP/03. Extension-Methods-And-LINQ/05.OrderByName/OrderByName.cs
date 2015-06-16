namespace StudentsAgeLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

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

        static void OrderStudentsByNameLINQ()
        {
            var orderedStudents =
                from student in students
                orderby student.FirstName, student.LastName
                select student;

            PrintStudents(orderedStudents);
        }

        static void OrderStudentsByNameLAMBDA()
        {
            var orderedStudents = students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            PrintStudents(orderedStudents);
        }

        static List<Student> students;

        static void Main()
        {
            students = new List<Student>(){new Student("Hristo","Stefanov"),
                                           new Student("Zara","Todorova"),
                                           new Student("Angel","Sheiretov"),
                                           new Student("Stoqn","Matev"),
                                           new Student("Dobrin","Angelov"),
                                           new Student("Marin","Petrov")};

            OrderStudentsByNameLINQ();
            Console.WriteLine(new string('-',50));
            Console.WriteLine();
            OrderStudentsByNameLAMBDA();
        }
    }
}
