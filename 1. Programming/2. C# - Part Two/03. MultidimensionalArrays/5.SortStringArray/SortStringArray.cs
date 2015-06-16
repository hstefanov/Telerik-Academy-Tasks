using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// You are given an array of strings.
/// Write a method that sorts the array by the length of its elements (the number of characters composing them).
/// </summary>

class SortStringArray
{
    public static string[] SortByNumOfChars(string[] arr)
    {
        string[] result = new string[arr.Length];

        Dictionary<string, int> sorted = new Dictionary<string, int>();

        foreach (string word in arr)
        {
            sorted.Add(word, word.Length);
        }

        var items = from pair in sorted
                    orderby pair.Value ascending
                    select pair;

        int count = 0;
        foreach (KeyValuePair<string, int> pair in items)
        {
            result[count] = pair.Key;
            count++;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter size of the string array : ");
        int size = int.Parse(Console.ReadLine());

        string[] wordArray = new string[size];

        //Initialize
        for (int i = 0; i < size; i++)
        {
            wordArray[i] = Console.ReadLine();
        }

        string[] sortedArr = SortByNumOfChars(wordArray);

        foreach (var item in sortedArr)
        {
            Console.WriteLine(item);
        }
    }
}
