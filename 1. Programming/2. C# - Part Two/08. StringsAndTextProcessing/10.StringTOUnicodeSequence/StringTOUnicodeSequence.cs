using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
/// </summary>

class StringTOUnicodeSequence
{
    private static void StringToUnicode(string input)
    {
        foreach (char c in input)
        {
           Console.Write(@"\u{0:X4}",(int)c);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string inputString = Console.ReadLine();
        StringToUnicode(inputString);
    }
}
