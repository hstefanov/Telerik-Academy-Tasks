using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that reads a text file and prints on the console its odd lines.
/// </summary>

class PrintOddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("sample.txt"))
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0} : {1}",lineNumber,line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}
