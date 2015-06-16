using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method GetMax() with two parameters that returns the bigger of two integers.
/// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
/// </summary>

class GetBiggestNumber
{
    private static int GetMax(int firstNum, int secondNum)
    {
        return (firstNum < secondNum ? secondNum : firstNum);
    }

    static void Main()
    {
        int[] inputNumbers = new int[3];
        Console.WriteLine("Enter numbers :");
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }

        int tempNum = int.MinValue;
        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            tempNum = GetMax(inputNumbers[i], inputNumbers[i + 1]);
        }

        Console.WriteLine("The biggest number is : {0}",tempNum);
    }
}
