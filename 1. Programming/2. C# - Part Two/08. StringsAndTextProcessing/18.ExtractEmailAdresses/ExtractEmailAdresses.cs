using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program for extracting all email addresses from given text.
/// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
/// </summary>

class ExtractEmailAdresses
{
    private static string text = "someone@abv.bg can use someone@gmail.com or someone@yahoo.com or many others or someone_other@google.com or me.me@gov.mil.bg";

    static void Main()
    {
        foreach(var item in Regex.Matches(text,@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]+\b",RegexOptions.IgnoreCase))
        {
            Console.WriteLine(item);
        }
    }
}
