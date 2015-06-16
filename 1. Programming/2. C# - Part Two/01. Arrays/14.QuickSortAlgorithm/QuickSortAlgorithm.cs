using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that sorts an array of strings using the quick sort algorithm 
/// </summary>

class QuickSortAlgorithm
{

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void QuickSortRecursive(int[] input, int left, int right)
    {
        int i = left;
        int j = right;
        int x = input[right];
        do
        {
            while (x > input[i])
            {
                i++;
            }

            while (x < input[j])
            {
                j--;
            }

            if (i <= j)
            {
                Swap(ref input[i], ref input[j]);
                i++;
                j--;
            }
        } while (j >= i);

        //Recursive calls8
        if (j > left)
        {
            QuickSortRecursive(input, left, j);
        }

        if (i < right)
        {
            QuickSortRecursive(input, i, right);
        }
    }

    static void Main()
    {
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        int[] inputArray = new int[size];

        //Initialize array
        for (int i = 0; i < size; i++)
        {
            Console.Write("inputArr[{0}] = ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        QuickSortRecursive(inputArray, 0, size - 1);
        foreach (var c in inputArray)
        {
            Console.WriteLine(c);
        }
    }
}
