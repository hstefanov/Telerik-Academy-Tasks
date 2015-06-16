using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Write a program that creates an array containing all letters from the alphabet (A-Z).
/// Read a word from the console and print the index of each of its letters in the array.
/// </summary>
/// 
class IndexOfLettersInWord
{
    private static void CreateAlphabet(char[] inputArr)
    {
        for (int i = 0; i < 26; i++)
        {
            inputArr[i] = (char)(i + 65);
        }
    }

    static void Main()
    {
        char[] alphabet = new char[26];
        CreateAlphabet(alphabet);

        Console.WriteLine("Enter word :");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("Index of letter {0} : {1}",word[i],Array.IndexOf(alphabet,Convert.ToChar(word[i].ToString().ToUpper())) + 1);
        }
    }
}
