using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

/// <summary>
/// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags
/// </summary>

class HTMLTitleAndBody
{
    private static string htmlText = string.Empty;

    private static string RemoveAllTags(string str)
    {
        string strWithoutTags = Regex.Replace(str, "<[^>]*>"," ");
        return strWithoutTags;
    }

    static void Main()
    {
        using(StreamReader reader = new StreamReader("page.txt"))
        {
            htmlText = reader.ReadToEnd();
        }
        Console.WriteLine(RemoveAllTags(htmlText));
    }
}
