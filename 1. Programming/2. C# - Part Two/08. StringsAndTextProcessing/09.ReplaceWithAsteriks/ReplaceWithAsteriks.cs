using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// We are given a string containing a list of forbidden words and a text containing some of these words.
/// Write a program that replaces the forbidden words with asterisks.
/// </summary>

class ReplaceWithAsteriks
{
    private static string text = "Microsoft announced its next generation PHP compiler today." + 
                                 "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

    private static string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

    static void Main()
    {
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            Match match = Regex.Match(text, "\\b" + forbiddenWords[i] + "\\b");
            if (match.Success)
            {
                text = Regex.Replace(text, "\\b" + forbiddenWords[i] + "\\b", new string('*', forbiddenWords[i].Length));
            }
        }
        Console.WriteLine(text);
    }
}
