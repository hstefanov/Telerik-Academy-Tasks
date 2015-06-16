using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that finds the most frequent number in an array. 
/// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
/// </summary>
class MostFrequentNumber
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

        Dictionary<int, int> elementsInArray = new Dictionary<int, int>();
        for (int i = 0; i < size; i++)
        {
            if (elementsInArray.ContainsKey(inputArray[i]))
            {
                elementsInArray[inputArray[i]] += 1;
            }
            else
            {
                elementsInArray.Add(inputArray[i], 1);
            }
        }

        var max = elementsInArray.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

        Console.WriteLine(max);
    }
}

