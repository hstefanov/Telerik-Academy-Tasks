/*
1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
mobile phone e-mail, course, specialty, university, faculty.
Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 */

namespace StudentTest
{
    using System;

    class StudentTest
    {
        static void Main()
        {
            Student firstStudent = new Student("Hristo", "Stefanov", "Stefanov", Speciality.ComputerScience, University.SoftUni, Faculty.FMI, 897456324, "some-adress", "+3596687941257", "hr@abv.bg", new Course("OOP", 1));

            Student secondStudent = firstStudent.Clone() as Student;
            secondStudent.SSN = 887456323;
            secondStudent.FirstName = "Angel";
            secondStudent.Course = new Course("Java Script", 2);

            Console.WriteLine("Information for the first Student : ");
            Console.WriteLine(firstStudent);
            Console.WriteLine();
            Console.WriteLine("Information for the second Student : ");
            Console.WriteLine(secondStudent);
            bool areEqual = firstStudent == secondStudent;
            Console.WriteLine("Are they same student? : {0}",areEqual);
            int compareStudents = int.MaxValue;
            compareStudents = firstStudent.CompareTo(secondStudent);
            switch (compareStudents)
            {
                //if the passed object isbigger than the this instance
                case -1 :
                    Console.WriteLine("Name of the second student is lexicographically bigger. or his SSN is bigger");
                    break;
                //if the passed object isequal to the this instance
                case 0:
                    Console.WriteLine("Students have same names and SSN's");
                    break;
                //if the passed object issmaller than the this instance
                case 1:
                    Console.WriteLine("Name of the first student is lexicographically bigger, or his SSN is bigger");
                    break;
            }
        }

        public static int compareStudents { get; set; }
    }
}
