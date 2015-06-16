using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that allocates array of 20 integers
/// and initializes each element by its index multiplied by 5. 
/// Print the obtained array on the console
/// </summary>
/// 

class AllocateArray
{
    static void Main()
    {
        int[] arr = new int[20];
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            arr[i] = i * 5;
        }

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

