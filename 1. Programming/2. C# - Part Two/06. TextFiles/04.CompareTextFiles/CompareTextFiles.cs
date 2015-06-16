using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/// <summary>
/// Write a program that compares two text files line by line and prints the number of lines 
/// that are the same and the number of lines that are different.
/// Assume the files have equal number of lines.
/// </summary>

class CompareTextFiles
{
    private static int same = 0;
    private static int different = 0;

    private static void CountLines(string fileName1,string fileName2)
    {
        string line1 = string.Empty;
        string line2 = string.Empty;
        using (StreamReader input1 = new StreamReader(fileName1))
        {
            using (StreamReader input2 = new StreamReader(fileName2))
            {
                line1 = input1.ReadLine();
                line2 = input2.ReadLine();
                while (line1 != null && line2 != null)
                {
                    if (line1 == line2)
                    {
                        same++;
                    }
                    else
                    {
                        different++;
                    }
                    line1 = input1.ReadLine();
                    line2 = input2.ReadLine();
                }
            }
        }
    }

    static void Main()
    {
        CountLines("first.txt","second.txt");
        Console.WriteLine("Number of same lines : {0}\nNumber of different lines : {1}",same,different);
    }
}
