using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// A dictionary is stored as a sequence of text lines containing words and their explanations.
/// Write a program that enters a word and translates it by using the dictionary
/// </summary>

class SampleDictionary
{
    private static string[] words = { ".NET", "CLR","namespace" };

    private static string[] explanations = {"platform for applications from Microsoft",
                                            "managed execution environment for .NET",
                                            "hierarchical organization of classes"};

    private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    private static void FillDicitonary(Dictionary<string, string> dictionary)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (!dictionary.ContainsKey(words[i]))
            {
                dictionary.Add(words[i], explanations[i]);
            }
        }
    }

    static void Main()
    {
        string word = Console.ReadLine();
        FillDicitonary(dictionary);

        foreach (KeyValuePair<string,string> pair in dictionary)
        {
            if (word == pair.Key)
            {
                Console.WriteLine("Explanation of the word {0} : {1}", pair.Key, pair.Value);
            }
        }
    }
}
