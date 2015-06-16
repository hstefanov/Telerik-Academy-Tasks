using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a string from the console and replaces 
/// all series of consecutive identical letters with a single one. 
/// Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
/// </summary>

class ReplaceConsecutiveLetters
{
    private static string input = "aaaaabbbbbcdddeeeedssaa";

    private static string ReplaceLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        result.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != result[result.Length - 1])
            {
                result.Append(input[i]);
            }
        }
        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ReplaceLetters(input));
    }
}

