using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// You are given a sequence of positive integer values written into a string, separated by spaces. 
/// Write a function that reads these values from given string and calculates their sum. 
/// Example: string = "43 68 9 23 318" -> result = 461
/// </summary>

class CalculateSum
{
    private static char[] trimSymbols = { ' ' };
    private static int SumIntegers(string sequence)
    {
        string[] tempSequence = sequence.Split(trimSymbols, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        foreach (string num in tempSequence)
        {
            sum += int.Parse(num.ToString());
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter sequence of numbers : ");
        string numSequence = Console.ReadLine();
        int result = SumIntegers(numSequence);
        Console.WriteLine("\"{0}\" -> {1}",numSequence,result);
    }
}
