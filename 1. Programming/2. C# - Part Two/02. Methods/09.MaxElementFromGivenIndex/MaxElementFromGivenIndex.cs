using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that return the maximal element in a portion of array of integers starting at given index. 
/// Using it write another method that sorts an array in ascending / descending order.
/// </summary>

class MaxElementFromGivenIndex
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    private static int GetMaxElement(int[] inputArr, int start)
    {
        int max = inputArr[start];
        for (int i = start + 1; i < inputArr.Length; i++)
        {
            if (max < inputArr[i])
            {
                max = inputArr[i];
            }
        }
        return max;
    }

    public static int[] SortDescending(int[] inputArr)
    {
        for (int i = 0; i < inputArr.Length; i++)
        {
            int max = GetMaxElement(inputArr, i);
            int index = Array.IndexOf(inputArr, max);
            Swap(ref inputArr[i], ref inputArr[index]);
        }
        return inputArr;
    }

    public static int[] SortAscending(int[] inputArr)
    {
        int[] sorted = new int[inputArr.Length];
        sorted = SortDescending(inputArr);
        Array.Reverse(sorted);
        return sorted;
    }

    static void Main()
    {
        //User input
        /*
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        int[] numArr = new int[size];

        //Init
        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }
        */

        int[] numArr = {1000,5,6,9,10,143,322,56};

        Console.Write("Enter startIndex :");
        int startIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximal element started from index {0} is : {1}",startIndex,GetMaxElement(numArr,startIndex));

        //Sort Descending
        SortDescending(numArr);
        Console.Write("Sorted Array Descending : ");
        foreach (int num in numArr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //Sort Ascending
        SortAscending(numArr);
        Console.Write("Sorted Array Descending : ");
        foreach (int num in numArr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
