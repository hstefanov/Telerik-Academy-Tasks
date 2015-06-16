using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that reads two arrays from the console and compares them element by element.
/// </summary>

class CompareTwoArrays
{
    private static bool Compare(int[] firstArr, int[] secondArr)
    {
        int length = firstArr.Length;

        bool equal = true;
        for (int i = 0; i < length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                equal = false;
            }
        }
        return equal;
    }

    static void Main()
    {
        Console.Write("Enter size of the arrays : ");
        int size = int.Parse(Console.ReadLine());
        
        int[] firstArr = new int[size];
        int[] secondArr = new int[size];

        //Initialize first array
        for (int i = 0; i < size; i++)
        {
            Console.Write("firstArr[{0}] = ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        //Initialize second array
        for (int i = 0; i < size; i++)
        {
            Console.Write("secondArr[{0}] = ", i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = Compare(firstArr, secondArr);
        Console.WriteLine("Are two arrays equal? : {0}",areEqual);
    }
}

