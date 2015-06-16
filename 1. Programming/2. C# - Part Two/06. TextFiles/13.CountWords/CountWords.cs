using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that reads a list of words from a file words.txt 
/// and finds how many times each of the words is contained in another file test.txt.
/// The result should be written in the file result.txt and the words should be sorted by the number of their occurrences 
/// in descending order.
/// Handle all possible exceptions in your methods.
/// </summary>

class CountWords
{
    private static string[] GetWordsToCount()
    {
        List<string> words = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader("words.txt"))
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

    private static string RemovePunctuation(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in input)
        {
            if (!char.IsPunctuation(ch))
            {
                sb.Append(ch);
            }
        }
        return sb.ToString();
    }

    static void Main()
    {
        string[] words = GetWordsToCount();
        string text = string.Empty;
        using (StreamReader reader = new StreamReader("test.txt"))
        {
            text = reader.ReadToEnd();
        }
        //remove punctuation and keep spaces to split!
        text = RemovePunctuation(text);

        //fill dictionary with words from file and set count to 0
        Dictionary<string, int> counts = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            counts.Add(words[i], 0);
        }

        //split string and check for every word
        string[] splittedText = text.Split(' ');
        foreach (string word in splittedText)
        {
            Console.WriteLine(word);
        }

        for (int i = 0; i < splittedText.Length; i++)
        {
            if (counts.ContainsKey(splittedText[i]))
            {
                counts[splittedText[i]] += 1;
            }
        }

        using (StreamWriter writer = new StreamWriter("result.txt"))
        {
            foreach (KeyValuePair<string, int> pair in counts)
            {
                writer.WriteLine("{0} : {1} times ", pair.Key, pair.Value);
            }
        }
    }
}
