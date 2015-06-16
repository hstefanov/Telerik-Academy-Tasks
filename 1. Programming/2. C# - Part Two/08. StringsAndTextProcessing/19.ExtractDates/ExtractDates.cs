using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
/// Display them in the standard date format for Canada.
/// </summary>
class ExtractDates
{
    private static string text = "today is 17.01.2014, the day before was 16.01.2014";

    static void Main()
    {
        foreach (Match item in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
        {
            Console.WriteLine(item.Value);
        }
    }
}
