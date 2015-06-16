using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
/// </summary>

class PrintWordsInAlphabeticalOrder
{
    private static char[] separators = { ' ' };

    static void Main()
    {
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
