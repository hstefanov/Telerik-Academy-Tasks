using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a string from the console and 
/// prints all different letters in the string along with information how many times each letter is found. 
/// </summary>

class PrintDifferentLetters
{
    private static string text = "AaAaAAABbbcd";
    private static Dictionary<string, int> letters = new Dictionary<string, int>();

    private static void FillDictionary(string text)
    {
        foreach (char c in text.ToLower())
        {
            if (!char.IsPunctuation(c) && c != ' ')
            {
                if (!letters.ContainsKey(c.ToString()))
                {
                    letters.Add(c.ToString(), 1);
                }
                else
                {
                    letters[c.ToString()]++;
                }
            }
        }
    }

    static void Main()
    {
        FillDictionary(text);

        foreach (KeyValuePair<string, int> pair in letters)
        {
            Console.WriteLine("Letter {0} apears {1} times",pair.Key,pair.Value);
        }
    }
}
