namespace FirstNameBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentClass; //Reference to StudentClass

    class FirstNameBeforeLast
    {
        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        static void FindStudentsFirstNameLastNameLinq()
        {
            var studentsFromSecondGroupWithLinq =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            PrintStudents(studentsFromSecondGroupWithLinq);
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
            FindStudentsFirstNameLastNameLinq();
        }
    }
}
