using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that removes from a text file all words listed in given another text file.
/// Handle all possible exceptions in your methods.
/// </summary>

class RemoveWordsFromFile
{
    private static string[] GetWordsToRemove()
    {
        List<string> words = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader("list.txt"))
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    words.Add(line);
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
       catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        return words.ToArray();
    }



    static void Main()
    {
        string[] words = GetWordsToRemove();
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = "\\b" + words[i] + "\\b";
                        line = Regex.Replace(line, word, "");
                    }

                    writer.WriteLine(line);

                    line = reader.ReadLine();
                }
            }
        }
    }
}
