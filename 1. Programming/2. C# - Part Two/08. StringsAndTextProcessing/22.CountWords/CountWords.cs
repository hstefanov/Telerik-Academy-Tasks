using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a string from the console and 
/// lists all different words in the string along with information how many times each word is found.
/// </summary>

class CountWords
{
    private static char[] separators = { ',', ' ' };
    private static string words = "word1, word2, word1, word1, word3, word3";
    private static Dictionary<string, int> letters = new Dictionary<string, int>();

    private static void FillDictionary(string[] words)
    {
        foreach (string word in words)
        {
            if (!letters.ContainsKey(word))
            {
                letters.Add(word, 1);
            }
            else
            {
                letters[word]++;
            }
        }
    }

    static void Main()
    {
        string[] splittedWords = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        FillDictionary(splittedWords);

        foreach (KeyValuePair<string, int> pair in letters)
        {
            Console.WriteLine("Word {0} apears {1} times", pair.Key, pair.Value);
        }
    }
}
