using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that reads a text file and inserts line numbers in front of each of its lines. 
/// The result should be written to another text file.
/// </summary>

class InsertLineNumbers
{
    private static string[] GetLinesWithNumbers(string filename)
    {
        List<string> lines = new List<string>();
        int lineCounter = 1;        
        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();
            while (line != null)
            {                          
                lines.Add(lineCounter + "." + line);
                lineCounter++;  
                line = reader.ReadLine();
            }
        }
        return lines.ToArray();
    }

    private static void WriteToFile(string[] lines)
    {
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        string[] lines = GetLinesWithNumbers("sample.txt");
        WriteToFile(lines);
    }
}
