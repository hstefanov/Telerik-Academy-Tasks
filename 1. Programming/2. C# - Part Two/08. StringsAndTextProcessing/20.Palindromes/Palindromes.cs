using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
/// </summary>

class Palindromes
{
    private static string text = "ABBA is palindrom, exe is also palindrom, lamal is palindrom";

    private static bool IsPalindrom(string text)
    {
        for (int i = 0; i < text.Length/2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        foreach (Match item in Regex.Matches(text, @"\w+"))
        {
            if (IsPalindrom(item.Value))
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
