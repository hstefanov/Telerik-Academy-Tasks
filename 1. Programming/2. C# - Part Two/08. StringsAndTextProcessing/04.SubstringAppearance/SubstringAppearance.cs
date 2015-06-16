using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
/// </summary>

class SubstringAppearance
{
    private static int CountSubstring(string input, string subStr)
    {
        int counter = 0;
        int index = input.IndexOf(subStr,StringComparison.CurrentCultureIgnoreCase);
        while(index != -1)
        {
            counter++;
            index = input.IndexOf(subStr, index + 1,StringComparison.CurrentCultureIgnoreCase);
        }
        return counter;
    }

    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substringToSearch = string.Empty;
        Console.WriteLine("Enter substring to search : ");
        substringToSearch = Console.ReadLine();
        Console.WriteLine("Substring {0} appear {1} times in the input string",substringToSearch,CountSubstring(text,substringToSearch));
    }
}
