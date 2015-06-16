using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that extracts from a given text all sentences containing given word.
/// </summary>

class ExtractSentences
{
    private static char[] separators = { '.' };
    private static string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    private static List<string> sentences = new List<string>();

    static void Main()
    {
        string[] sentences = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            Match match = Regex.Match(sentence,@"\bin\b");
            if (match.Success)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
