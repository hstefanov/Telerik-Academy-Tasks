using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

/// <summary>
/// Modify the solution of the previous problem to replace only whole words (not substrings).
/// </summary>

class ReplaceWholeWords
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                string pattern = @"\b(start)\b";
                Regex rgx = new Regex(pattern);

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = rgx.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }
        }
    }
}
