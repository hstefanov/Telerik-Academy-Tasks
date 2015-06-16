using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
/// Find in the array those K elements that have maximal sum.
/// </summary>
/// 
class KElementsOfMaxSum
{
    static void Main()
    {
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter number of elements to search : ");
        int numElements = int.Parse(Console.ReadLine());

        int[] inputArray = new int[size];

        //Initialize array
        for (int i = 0; i < size; i++)
        {
            Console.Write("firstArr[{0}] = ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(inputArray);

        Console.Write("Elements with maximum sum : ");
        for (int i = inputArray.Length - numElements; i < inputArray.Length; i++)
        {
            Console.Write(" {0} ",inputArray[i]);
        }
        Console.WriteLine();

    }
}

