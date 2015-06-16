using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that deletes from given text file all odd lines. The result should be in the same file.
/// </summary>

class DeleteOddLines
{
    private static List<string> GetEvenLines(string fileName)
    {
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(fileName))
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    lines.Add(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
        return lines;
    }

    private static void WriteOddLines(List<string> lines,string fileName)
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
        WriteOddLines(GetEvenLines("input.txt"), "input.txt");
    }
}
