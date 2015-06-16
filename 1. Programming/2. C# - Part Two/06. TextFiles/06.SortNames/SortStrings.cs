using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
/// Example:
///	Ivan			George
///	Peter	-->		Ivan
///	Maria			Maria
///	George			Peter
/// </summary>

class SortStrings
{
    private static List<string> GetStrings(string fileName)
    {
        List<string> strings = new List<string>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            for (string line; (line = reader.ReadLine()) != null; )
            {
                strings.Add(line);
            }
        }
        return strings;
    }

    private static void WriteStrings(List<string> lines, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        List<string> strings = GetStrings("input.txt");
        strings.Sort();
        WriteStrings(strings, "output.txt");
    }
}
