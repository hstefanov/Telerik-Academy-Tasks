using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program, that reads from the console an array of N integers and an integer K, 
/// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
/// </summary>

class BinSearchMaxK
{
    static void Main()
    {
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Enter value for K : ");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        int Result;

        //Initialize
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter value for arr[{0}] : ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        if (arr[0] > K) Console.WriteLine("There is no number that is less than or equal to K.");
        else
        {
            int IndexOfElement = Array.BinarySearch(arr, K);
            if (IndexOfElement >= 0)
            {
                Result = arr[IndexOfElement];
            }
            else
            {
                int tempIndex = ~IndexOfElement - 1;    //If this index is equal to the size of the array, there are no elements larger than value in the array. 
                Result = arr[tempIndex];    //Otherwise, it is the index of the first element that is larger than value. 
            }
                                                  
            Console.WriteLine(Result);
        }
    }
}