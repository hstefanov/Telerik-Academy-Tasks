using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that counts how many times given number appears in given array.
/// Write a test program to check if the method is working correctly.
/// </summary>

class DigitCounter
{
    public static int CountGivenNumber(int[] input,int number)
    {
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        //input array of numbers
        Console.Write("Enter size of the array : ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //method result
        Console.Write("Which number to count? ");
        int numberToCount = int.Parse(Console.ReadLine());

        int methodResult = CountGivenNumber(numbers, numberToCount);
        Console.WriteLine("Number {0} : {1} times",numberToCount,methodResult);


        //test program
        int testCounter = 0;
        foreach (int num in numbers)
        {
            if (num == numberToCount)
            {
                testCounter++;
            }
        }

        if (testCounter == methodResult)
        {
            Console.WriteLine("Method works correctly!");
        }
    }
}
