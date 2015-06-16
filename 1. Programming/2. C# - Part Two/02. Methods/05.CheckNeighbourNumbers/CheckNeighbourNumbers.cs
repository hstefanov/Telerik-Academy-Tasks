using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that checks if the element at given position in given array of integers
/// is bigger than its two neighbors (when such exist).
/// </summary>

class CheckNeighbourNumbers
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

    private static bool IsBigger(int[] inputArr,int[] numbers, int index)
    {
        Array.Sort(numbers);
        if (inputArr[index] == numbers[numbers.Length - 1])
        {
            return true;
        }
        return false;
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
        int[] numArr = {6,4,7,89,12,1};
        Console.Write("Enter the position to search : ");
        int position = int.Parse(Console.ReadLine());

        bool bigger;
        try
        {
            if (ExistNeighbours(numArr, position))
            {
                int[] container = GetNumAndItsNeighbours(numArr, position);
                bigger = IsBigger(numArr, container, position);
                if (bigger)
                {
                    Console.WriteLine("Number {0} is bigger than its neigbours", numArr[position]);
                }
                else
                {
                    Console.WriteLine("Number {0} is smaller than its neigbours", numArr[position]);
                }
            }
            else
            {
                Console.WriteLine("Number {0} doesn't have neighbours", numArr[position]);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("The position you have entered is bigger than the array size!");
            Console.WriteLine("Array size : {0}",numArr.Length);
        }
    }
}
