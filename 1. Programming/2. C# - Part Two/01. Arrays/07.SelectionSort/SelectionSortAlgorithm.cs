using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
/// Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
/// find the smallest from the rest, move it at the second position, etc.
/// </summary>
/// 
class SelectionSortAlgorithm
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = 0;
        temp = a;
        a = b;
        b = temp;      
    }

    //Sorting logic
    public static int[] SelectionSort(int[] inputArr)
    {
        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            for (int j = i + 1; j < inputArr.Length; j++)
            {
                if (inputArr[i] > inputArr[j])
                {
                    Swap(ref inputArr[i], ref inputArr[j]);
                }
            }
        }
        return inputArr;
    }

    static void Main()
    {
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        int[] inputArray = new int[size];

        //Initialize array
        for (int i = 0; i < size; i++)
        {
            Console.Write("firstArr[{0}] = ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedArray = SelectionSort(inputArray);
        Console.Write("Sorted array : ");
        foreach (int num in sortedArray)
        {
            Console.Write(" {0} ", num);
        }
        Console.WriteLine();
    }
}

