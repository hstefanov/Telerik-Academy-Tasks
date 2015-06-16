using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that concatenates two text files into another text file.
/// </summary>

class ConcatenateTwoFiles
{
    private static void WriteToFile(StreamWriter output, string file)
    {
        using (StreamReader reader = new StreamReader(file,Encoding.GetEncoding("Windows-1251")))
        {
            string text = reader.ReadToEnd();
            output.Write(text);
        }
    }

    static void Main()
    {
        string[] files = { "contents1.txt", "contents2.txt" };
        using(StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (string file in files)
            {
                WriteToFile(writer, file);

            }
        }
    }
}
