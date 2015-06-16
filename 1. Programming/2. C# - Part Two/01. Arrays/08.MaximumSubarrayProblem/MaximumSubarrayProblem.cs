using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that finds the sequence of maximal sum in given array. 
/// Example : {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
/// Can you do it with only one loop (with single scan through the elements of the array)?
/// </summary>

///In computer science, the maximum subarray problem is the task of finding the contiguous subarray 
///within a one-dimensional array of numbers (containing at least one positive number) which has the largest sum. 
///For example, for the sequence of values −2, 1, −3, 4, −1, 2, 1, −5, 4; 
///the contiguous subarray with the largest sum is 4, −1, 2, 1, with sum 6.
///Kadane's algorithm
///Source : http://en.wikipedia.org/wiki/Maximum_subarray_problem

class MaximumSubarrayProblem
{
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

        //Begin algorithm
        int maxSoFar = inputArray[0];
        int maxEndHere = inputArray[0];
        int begin = 0;
        int tempBegin = 0;
        int end = 0;

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            maxEndHere += inputArray[i];
            if (inputArray[i] > maxEndHere)
            {
                maxEndHere = inputArray[i];
                tempBegin = i;
            }
            else
            {
                maxEndHere += inputArray[i];
            }

            if (maxEndHere > maxSoFar)
            {
                maxSoFar = maxEndHere;
                begin = tempBegin;
                end = i;
            }
        }

        Console.Write("Subarray with max sum :");
        for (int i = begin; i <= end; i++)
        {
            Console.Write(" {0} ",inputArray[i]);
        }
    }
}

