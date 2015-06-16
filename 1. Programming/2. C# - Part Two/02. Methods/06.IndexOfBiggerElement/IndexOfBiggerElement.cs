using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that returns the index of the first element in array that is bigger than its neighbors,
/// or -1, if there’s no such element.
/// </summary>

class IndexOfBiggerElement
{
    private static bool ExistNeighbours(int[] inputArr, int index)
    {
        return (index + 1 < inputArr.Length && index - 1 >= 0);
    }

    private static int[] GetNumAndItsNeighbours(int[] inputArr, int index)
    {
        int[] tempArr = new int[3];
        for (int i = 0, j = index - 1; i < 3; i++, j++)
        {
            tempArr[i] = inputArr[j];
        }
        return tempArr;
    }

    private static bool IsBigger(int[] inputArr, int[] numbers, int index)
    {
        Array.Sort(numbers);
        if (inputArr[index] == numbers[numbers.Length - 1])
        {
            return true;
        }
        return false;
    }

    private static int IndexOfFirstBiggerElement(int[] numArr)
    {
        bool bigger;
        for (int position = 0; position < numArr.Length; position++)
        {
            if (ExistNeighbours(numArr, position))
            {
                int[] container = GetNumAndItsNeighbours(numArr, position);
                bigger = IsBigger(numArr, container, position);
                if (bigger)
                {
                    return position;
                }
            }
            else
            {
                continue;
            }
        }
        return -1;
    }

    static void Main()
    {
        //User input
        /*
        Console.Write("Enter size of the array :");
        int size = int.Parse(Console.ReadLine());
        int[] numArr = new int[size];
        
        //Init
        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }
        */

        //test array
        int[] numArr = { 100,6,66, 4, 7, 89, 12, 1 };

        Console.WriteLine("Index of the first element that is bigger thant its neighbours : {0}",IndexOfFirstBiggerElement(numArr));
    }
}
