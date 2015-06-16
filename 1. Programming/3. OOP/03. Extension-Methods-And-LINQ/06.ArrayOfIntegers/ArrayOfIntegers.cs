/*
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

namespace ArrayOfIntegers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class ArrayOfIntegers
    {
        static void PrintNums(IEnumerable<int> integerArray)
        {
            foreach (var num in integerArray)
            {
                Console.WriteLine(num);
            }
        }

        static int[] integerArray = new int[] { 10, 20, 21, 42, 3, 5 };

        static void Main()
        {
            //LAMBDA
            int[] resultArray = integerArray.Where(x => x % 21 == 0).ToArray();

            PrintNums(resultArray);

            //LINQ
            int[] secondResultArray = (from num in integerArray
                                       where num % 21 == 0
                                       select num).ToArray();

            PrintNums(secondResultArray);    
        }
    }
}
