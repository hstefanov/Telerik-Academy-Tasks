/*
4.Create a class Person with two fields – name and age.
Age can be left unspecified (may contain null value). 
Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
Define a class BitArray64 to hold 64 bit values inside an ulong value. 
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/

namespace PersonTest
{
    using System;

    class PersonTest
    {
        static void Main()
        {
            Person firstPerson = new Person("Pesho",null);
            Person secondPerson = new Person("Ivan", 26);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
