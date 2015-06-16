using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that encodes and decodes a string using given encryption key (cipher). 
/// The key consists of a sequence of characters. 
/// The encoding/decoding is done by performing XOR (exclusive or) operation
/// over the first letter of the string with the first of the key, the second – with the second, etc. 
/// When the last key character is reached, the next is the first.
/// </summary>

class EncodeDecode
{
    private static string Encode(string input, string key)
    {
        StringBuilder sb = new StringBuilder(input.Length);
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append((char)(input[i] ^ key[i % key.Length]));
        }
        return sb.ToString();
    }

    private static string Decode(string input, string key)
    {
        return Encode(input, key);
    }

    static void Main()
    {
        Console.Write("Enter string to encode :");
        string inputString = Console.ReadLine();
        Console.Write("Enter encryption key : ");
        string encryptionKey = Console.ReadLine();
        Console.WriteLine(Encode(inputString, encryptionKey));
        Console.WriteLine(Decode(Encode(inputString, encryptionKey),encryptionKey));
    }
}
