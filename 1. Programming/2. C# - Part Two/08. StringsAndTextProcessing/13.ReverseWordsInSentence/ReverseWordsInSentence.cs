using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reverses the words in given sentence.
/// Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
/// </summary>

class ReverseWordsInSentence
{
    private static string sentence = "C# is not C++, not PHP and not Delphi!";
    private static char[] separators = { ' ' };

    private static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(separators,StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder(sentence.Length);
        for (int i = words.Length - 1; i >= 0 ; i--)
        {
            sb.Append(words[i] + ' ');
        }
        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine((ReverseWords(sentence)));
    }
}
