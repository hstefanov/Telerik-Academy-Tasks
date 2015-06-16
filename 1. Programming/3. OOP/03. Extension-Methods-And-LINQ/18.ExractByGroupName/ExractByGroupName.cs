﻿namespace ExractByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public Student(string fullName, string groupName)
        {
            this.FullName = fullName;
            this.GroupName = groupName;
        }

        public string FullName { get; private set; }

        public string GroupName { get; private set; }
    }

    class ExractByGroupName
    {
        /// <summary>
        /// 18.Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
        /// </summary>
        static void GroupByGroupNameWithLinq()
        {
            var studentsGroupedByGroupNameWithLinq =
                from student in students
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in studentsGroupedByGroupNameWithLinq)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(currentGroup.Key);
                Console.ResetColor();

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 19.Rewrite the previous using extension methods.
        /// </summary>
        static void GroupByGroupNameWithLambda()
        {
            var studentsGroupedByGroupNameWithLambda = students.GroupBy(x => x.GroupName).OrderBy(x => x.Key);

            foreach (var currentGroup in studentsGroupedByGroupNameWithLambda)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(currentGroup.Key);
                Console.ResetColor();

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        static Student[] students;
        static void Main()
        {
            students = new Student[]
            {
                new Student("Hristo Stefanov", "Telerik"),
                new Student("Stoqn Matev", "Telerik"),
                new Student("Dobrin Rusev", "MoD"),
                new Student("Marin Petrov", "MoD"),
                new Student("Veliko Belchev", "MoD"),
                new Student("Martin Nikolchev", "Telerik")
            };

            GroupByGroupNameWithLinq();

            GroupByGroupNameWithLambda();
        }
    }
}
