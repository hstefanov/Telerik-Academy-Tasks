using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads from the console a string of maximum 20 characters. 
/// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
/// Print the result string into the console.
/// </summary>

class FillString
{
    private static string Fill(string input)
    {
        return input.PadRight(20, '*');
    }

    static void Main()
    {
        Console.Write("Enter a string of maximum 20 characters : ");
        string inputString = string.Empty;
        do
        {
            inputString = Console.ReadLine();
            if (inputString.Length > 20)
            {
                Console.WriteLine("String must be of maximum 20 characters!");
            }
        } while (inputString.Length > 20);
        if (inputString.Length < 20)
        {
            Console.WriteLine(Fill(inputString));
        }
        else
        {
            Console.WriteLine(inputString);
        }
    }
}
