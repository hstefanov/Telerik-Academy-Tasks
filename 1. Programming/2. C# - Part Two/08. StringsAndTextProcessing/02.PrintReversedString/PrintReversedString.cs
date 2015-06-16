using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a string, reverses it and prints the result at the console. Example: "sample" -> "elpmas".
/// </summary>

class PrintReversedString
{
    private static string ReverseString(string input)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = input.Length - 1; i >=0 ; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine(ReverseString("sample"));
    }
}
