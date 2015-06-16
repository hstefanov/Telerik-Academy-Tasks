using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Write a program that finds the maximal sequence of equal elements in an array.
/// </summary>

class MaxSequenceEqualElements
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

        List<int> resultContainer = new List<int>();
        int len = 1;
        int bestLen = 1;
        int start = 0;
        int bestStart = 0;

        for (int i = 0; i < size - 1; i++)
        {
            if (inputArray[i] != inputArray[i + 1])
            {
                len = 1;
                start = i + 1;
            }
            else
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
        }

        for (int i = bestStart ; i < bestStart + bestLen; i++)
        {
            resultContainer.Add(inputArray[i]);
        }

        Console.Write("Best sequence : ");
        Console.Write("{");
        foreach (int num in resultContainer)
        {
            Console.Write(" " + num + " " );
        }
        Console.WriteLine("}");
    }
}

        