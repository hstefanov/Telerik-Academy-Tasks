using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

/// <summary>
/// Write a program that extracts from given XML file all the text without the tags. Example:
/// </summary>

class ExtractWords
{
    private static string RemoveAllTags(string fileName)
    {
        string text = string.Empty;
        using (StreamReader reader = new StreamReader(fileName))
        {
            text = reader.ReadToEnd();
        }
        string strWithoutTags = Regex.Replace(text, "<[^>]*>", "\n");
        return strWithoutTags;
    }

    static void Main()
    {
        Console.WriteLine(RemoveAllTags("input.txt"));
    }
}
