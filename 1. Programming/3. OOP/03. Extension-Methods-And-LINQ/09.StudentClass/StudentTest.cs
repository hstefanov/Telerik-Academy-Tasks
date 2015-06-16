namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 09.Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
        /// </summary>
        static void FindStudentsFromSecondGroupWithLinq()
        {
            var studentsFromSecondGroupWithLinq =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            PrintStudents(studentsFromSecondGroupWithLinq);
        }

        /// <summary>
        /// 10.Implement the previous using the same query expressed with extension methods.
        /// </summary>
        static void FindStudentsFromSecondGroupWithLambda()
        {
            var studentsFromSecondGroupWithLambda = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            PrintStudents(studentsFromSecondGroupWithLambda);
        }

        /// <summary>
        /// 11.Extract all students that have email in abv.bg. Use string methods and LINQ.
        /// </summary>
        static void FindStudentsWithEmailInAbv()
        {
            var studentWithEmailInAbv =
                from student in students
                where student.Email.EndsWith("abv.bg")
                select student;

            // solution with lambda expression
            // var studentsWithEmailInAbvLambda = students.Where(st => st.Email.EndsWith("abv.bg"));
            // Print(studentsWithEmailInAbvLambda);

            PrintStudents(studentWithEmailInAbv);
        }

        /// <summary>
        /// 12.Extract all students with phones in Sofia. Use LINQ.
        /// </summary>
        static void FindStudentsWithSofiaPhoneNumber()
        {
            var studentsWithSofiaPhoneNumbers =
                from student in students
                where student.phoneNumber.StartsWith("02")
                select student;

            // studentsWithSofiaPhoneNumbersLambda = students.Where(st => st.Tel.StartsWith("02"));
            // Print(studentsWithSofiaPhoneNumbersLambda);

            PrintStudents(studentsWithSofiaPhoneNumbers);
        }

        /// <summary>
        /// 13.Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
        /// </summary>
        static void FindStudentsWithAtLeastOneExcellentMark()
        {
            var studentsWithExcellentMark =
                from student in students
                where student.ContainMark(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            //solution with lambda expression
            //var studentsWithExcellentMarkLambda = students.Where(st => st.ContainMark(6)).Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            //foreach (var student in studentsWithExcellentMarkLambda)
            //{
            // Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            //}

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }
        }

        /// <summary>
        /// 14.Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.
        /// </summary>
        static void FindStudentsWithExactlyTwoMarks2()
        {
            const int markToFind = 2;
            const int markAppearences = 2;

            var studentsWithExactlyTwoMarks2 =
                from student in students
                where student.Marks.Count(x => x == markToFind) == markAppearences
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            //solution with lambda expressions
            //var studentsWithExactlyTwoMarks2Lambda = students.Where(st => st.Marks.Count(m => m == markToFind) == markAppearences).Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            //foreach (var student in studentsWithExactlyTwoMarks2Lambda)
            //{
            // Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            //}

            foreach (var student in studentsWithExactlyTwoMarks2)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// 15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        /// substring from element on position 4 (not position 5) because the indeces start from 0
        /// </summary>
        static void FindStudentMarksEnrolledIn2006()
        {
            var studentsEnrolledIn2006 =
                from student in students
                where student.FN.Substring(4, 2) == "06"
                select new { FullName = student.FirstName + " " + student.LastName, FN = student.FN, Marks = student.GetMarks() };

            //solution with lambda expressions
            //var studentsEnrolledIn2006Lambda = students.Where(st => st.FN.Substring(4, 2) == "06").Select(st => new { FullName = st.FirstName + " " + st.LastName, FN = st.FN, Marks = st.GetMarks() });

            //foreach (var student in studentsEnrolledIn2006Lambda)
            //{
            // Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.FN, student.Marks);
            //}
            //Console.WriteLine();

            foreach (var student in studentsEnrolledIn2006)
            {
                Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.FN, student.Marks);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 16*. Create a class Group with properties GroupNumber and DepartmentName.
        /// Introduce a property Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.
        /// </summary>
        static void FindStudentsInMathematicsDepartment()
        {
            Group[] groups = new Group[]
            {
                new Group(15, "Mathematics"),
                new Group(11, "Medicine"),
                new Group(3, "Physics"),
                new Group(1, "Chemistry")
            };

            var result =
                from g in groups
                join s in students on g.DepartmentName equals s.Group.DepartmentName
                where g.DepartmentName == "Mathematics"
                select new { Dep = s.Group.DepartmentName, Name = s.FirstName + " " + s.LastName };

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " -> " + item.Dep);
            }
        }

        static IEnumerable<Student> students;

        static void Main()
        {
            students = new List<Student>() { new Student("Pesho", "Petrov", "772206", "0212345","pesho@abv.bg", new List<int> { 3, 4 }, 2, new Group(15, "Mathematics")),
                                             new Student("Ivan", "Marinov", "771805","0312345","ivan@gmail.com", new List<int> {6, 5,}, 1, new Group(15, "Physics")),
                                             new Student("Neli", "Petrova", "772206","0412345","neli@gmail.com", new List<int> {6, 5, 6,}, 2, new Group(15, "Mathematics")),
                                             new Student("Desi", "Mateva",  "772206","0212345","dess@gmail.com", new List<int> {6, 6, 6}, 1, new Group(15, "Physics")),
                                             new Student("Georgi", "Ivanov","771805","0512345","gogo@gmail.com", new List<int> {6, 5, 6, 3}, 1, new Group(15, "Physics")),
                                             new Student("Petko", "Petrov", "771604","0512345","petko@gmail.com", new List<int> {6, 4}, 2, new Group(15, "Mathematics")),
                                             new Student("Stoqn", "Stoqnov", "771604","03212345","ivan@gmail.com", new List<int> {6, 5, 5}, 3, new Group(15, "Chemistry")),
                                             new Student("Dobrin", "Dobrinov","771805","0212345","ivan@gmail.com", new List<int> {6, 6, 6, 6}, 3, new Group(15, "Chemistry")),
                                             new Student("Marin", "Petrov", "771604","0712345","ivan@gmail.com", new List<int> {3,3,4}, 3, new Group(15, "Chemistry"))};
            Console.WriteLine(new string('-',50));
            FindStudentsFromSecondGroupWithLinq();
            Console.WriteLine(new string('-',50));
            FindStudentsFromSecondGroupWithLambda();
            Console.WriteLine(new string('-',50));
            FindStudentsWithEmailInAbv();
            Console.WriteLine(new string('-',50));
            FindStudentsWithSofiaPhoneNumber();
            Console.WriteLine(new string('-',50));
            FindStudentsWithAtLeastOneExcellentMark();
            Console.WriteLine(new string('-', 50));
            FindStudentsWithExactlyTwoMarks2();
            Console.WriteLine(new string('-', 50));
            FindStudentMarksEnrolledIn2006();
            Console.WriteLine(new string('-', 50));
            FindStudentsInMathematicsDepartment();
            Console.WriteLine(new string('-', 50));
        }
    }
}
