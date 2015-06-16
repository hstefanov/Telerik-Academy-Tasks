using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
/// </summary>
/// 
class BinarySearch
{
    private static uint getMaxPower2(uint num)
    {
        uint pow2;
        for (pow2 = 1; pow2 <= num; pow2 <<= 1) ;
        return pow2 >> 1;
    }

    //First variant
    private static uint BinSearch(int[] inputArr,int key,uint min, uint max)
    {
        while (min <= max)
        {
            //calculate middle of the array
            uint mid = (min + max) / 2;
            if (inputArr[mid] == key)
            {
                //key found at index mid
                return mid;
            }
            //determine which subarray to search
            else if (inputArr[mid] < key)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        return 0;
    }

    //Second variant
    private static uint BinSearchOptimized(int[] inputArr, int key)
    {
        uint i, left, index;
        i = getMaxPower2((uint)inputArr.Length);
        if (inputArr[i] >= key)
        {
            left = 0;
        }
        else
        {
            left = (uint)(inputArr.Length - i + 1);
        }
        while (i > 0)
        {
            i >>= 1;
            index = left + 1;
            if (inputArr[index] == key)
            {
                return index;
            }
            else if (inputArr[index] < key)
            {
                left = index;
            }
        }
        return 0;
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

        //Sort
        Array.Sort(inputArray);

        Console.Write("Index of the element : ");
        uint index = BinSearch(inputArray, 3, 0, (uint)inputArray.Length  -1);
        Console.WriteLine(index);

        Console.WriteLine("Binary Search Optimized :");
        Console.Write("Index of the element : ");
        uint index2 = BinSearchOptimized(inputArray, 3);
        Console.WriteLine(index2);
    }
}

