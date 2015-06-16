using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that compares two char arrays lexicographically (letter by letter).
/// </summary>


class CompareArraysLexicographically
{
    static void Main()
    {     
        //size of first array
        Console.Write("Enter size for the first array : ");
        int firstLen = int.Parse(Console.ReadLine());

        //size of second array
        Console.Write("Enter size for the second array : ");
        int secondLen = int.Parse(Console.ReadLine());

        char[] firstArr = new char[firstLen];
        char[] seconArr = new char[secondLen];

        //Initialize arrays
        for (int i = 0; i < firstLen; i++)
        {
            Console.Write("firstArr[{0}] : ", i);
            firstArr[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        for (int i = 0; i < secondLen; i++)
        {
            Console.Write("secondArr[{0}] : ", i);
            seconArr[i] = char.Parse(Console.ReadLine());
        }

        int comparisonLength = Math.Min(firstLen, secondLen);
        bool areEqual = true;

        for (int i = 0; i < comparisonLength; i++)
        {
            if (firstArr[i] != seconArr[i])
            {
                areEqual = false;
                if (firstArr[i] < seconArr[i])
                {
                    Console.WriteLine("The first array is lexicografically before the second!");
                    break;
                }
                else
                {
                    Console.WriteLine("The second array is lexicografically before the first!");
                    break;
                }
            }
        }

        if (areEqual == true && firstLen == secondLen)
        {
            Console.WriteLine("The two arrays are equal!");
        }
        else if (areEqual == true && firstLen < secondLen)
        {
            Console.WriteLine("The first array is lexicografically before the second because it is smaller in size!");
        }
        else if(areEqual == true && firstLen > secondLen)
        {
            Console.WriteLine("The second array is lexicografically before the first because it is smaller in size!");
        }
    }
}

