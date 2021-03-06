﻿/*
01. We are given a school. In the school there are classes of students. 
Each class has a set of teachers. Each teacher teaches a set of disciplines.
Students have name and unique class number. Classes have unique text identifier.
Teachers have name. Disciplines have name, number of lectures and number of exercises.
Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace ShcoolTest
{
    using System;
    using System.Collections.Generic;

    class ShcoolTest
    {
        static void Main()
        {
            List<Student> students = new List<Student>(){new Student("Ivan",10),
                                                         new Student("Gosho",3),
                                                         new Student("Pesho",17),
                                                         new Student("Svetlio",25)};

            List<Teacher> teachers = new List<Teacher>(){new Teacher("Kaloqn",new List<Discipline>(){new Discipline("Math",10,20)}),
                                                         new Teacher("Plamen",new List<Discipline>(){new Discipline("Chemistry",5,10)}),
                                                         new Teacher("Gergana",new List<Discipline>(){new Discipline("Biology",15,10)})};

            Class shcoolClass = new Class(students, teachers, "12-g");

            shcoolClass.AddComment("Programming champions");

            Console.WriteLine(shcoolClass);
        }
    }
}
