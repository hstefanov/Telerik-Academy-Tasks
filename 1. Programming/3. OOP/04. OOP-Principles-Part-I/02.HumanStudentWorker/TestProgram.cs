
/*
02.Define abstract class Human with first name and last name.
Define new class Student which is derived from Human and has new field – grade.
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
that returns money earned by hour by the worker. 
Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/

namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestProgram
    {
        static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        static void PrintWorkers(IEnumerable<Worker> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Gosho", "Georgiev", 2),
                new Student("Pesho", "Petrov", 10),
                new Student("Kalina", "Angelov", 5),
                new Student("Angel", "Angelov", 4),
                new Student("Gergana", "Stefanova", 6),
                new Student("Petko", "Kalchev", 1),
                new Student("Gero", "Filipov", 11),
                new Student("Tanq", "Petrova", 12),
                new Student("Hristo", "Stefanov", 26),
                new Student("Stoqn", "Matev", 7)};

            var sortedStudentsByGrade = students.OrderBy(student => student.Grade).ToList();
            Console.WriteLine("Sorted students : ");           
            PrintStudents(sortedStudentsByGrade);
            Console.WriteLine();


            List<Worker> workers = new List<Worker>()
          {
              new Worker( "Borislav","Manolov", 250, 20 ),
              new Worker( "Miroslav","Todorov", 350, 20 ),
              new Worker( "Plamen","Panchev", 50, 20 ),
              new Worker( "Dobrin","Rusev", 1500, 20 ),
              new Worker( "Miglena","Koleva", 800, 20 ),
              new Worker( "Denica","Andonova", 210, 20 ),
              new Worker( "Nevena","Kokalova    ", 30, 20 ),
              new Worker( "Svetozara","Ivanova", 145, 20 ),
              new Worker( "Nedko","Marinov", 731, 20 ),
              new Worker( "Vasil","Vasilev", 235, 20 )
          };

            var sortedWorkersByMoneyPerHour = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine("Sorted Workers : ");
            PrintWorkers(sortedWorkersByMoneyPerHour);
            Console.WriteLine();


            var mergedLists = workers.Concat<Human>(students).ToList();
            mergedLists = mergedLists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            Console.WriteLine("Sorted Humans by name : ");
            foreach (var item in mergedLists)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
