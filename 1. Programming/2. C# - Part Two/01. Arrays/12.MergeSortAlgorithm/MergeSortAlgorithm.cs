using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// * Write a program that sorts an array of integers using the merge sort algorithm
/// </summary>

class MergeSortAlgorithm
{
    public static void Merge(int[] inputArr, int left, int mid, int right)
    {
        int[] tempArr = new int[inputArr.Length];
        int leftEnd = mid - 1;
        int tmpPos = left;
        int numElements = (right - left) + 1;

        while((left <= leftEnd) && (mid <= right))
        {
            if (inputArr[left] <= inputArr[mid])
            {
                tempArr[tmpPos] = inputArr[left];
                tmpPos++;
                left++;
            }
            else
            {
                tempArr[tmpPos] = inputArr[mid];
                tmpPos++;
                mid++;
            }
        }

        while (left <= leftEnd)
        {
            tempArr[tmpPos] = inputArr[left];
            tmpPos++;
            left++;
        }

        while (mid <= right)
        {
            tempArr[tmpPos] = inputArr[mid];
            tmpPos++;
            mid++;
        }

        for (int i = 0; i < numElements; i++)
        {
            inputArr[right] = tempArr[right];
            right--;
        }
    }

    public static void MergeSortRecursive(int[] inputArr, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (left + right) / 2;
            MergeSortRecursive(inputArr, left, mid);
            MergeSortRecursive(inputArr, mid + 1, right);

            Merge(inputArr, left, mid + 1, right);
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

        //MergeSort
        MergeSortRecursive(inputArray, 0, size - 1);
        Console.Write("Sorted sequence : ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(" {0} ", inputArray[i]);
        }
        Console.WriteLine();
    }
}

