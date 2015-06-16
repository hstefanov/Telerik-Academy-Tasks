using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that finds in given array of integers a sequence of given sum S (if present). 
/// Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
/// </summary>
/// 
class FindSequenceByGivenSum
{
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

        Console.Write("Enter sum :");
        int sum = int.Parse(Console.ReadLine());

        int startIndex = 0;
        int endIndex = 0;
        bool isFound = false;
        bool end = true;

        while (!isFound && end)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int tempSum = 0;
                tempSum += inputArray[i];
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    tempSum += inputArray[j];
                    if (tempSum == sum)
                    {
                        startIndex = i;
                        endIndex = j;
                        isFound = true;
                    }
                    else if(i == inputArray.Length - 2 && j == inputArray.Length - 1)
                    {
                        end = false;
                    }
                }
            }
        }

        if (isFound)
        {
            Console.Write("Result :");
            Console.Write("{");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(" {0} ", inputArray[i]);
            }
            Console.WriteLine("}");
        }
        else
        {
            Console.WriteLine("Result not found!");
        }
    }
}
