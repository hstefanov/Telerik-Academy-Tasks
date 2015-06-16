using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
/// The tags cannot be nested
/// </summary>

class ToUpperCase
{
    private static string openTag = "<upcase>";
    private static string closeTag = "</upcase>";

    private static string UpcaseTag(string input)
    {
        StringBuilder sb = new StringBuilder();
        int index = input.IndexOf("<");

        for (int i = 0; i < input.Length; i++)
        {
            if (i == index)
            {
                i += openTag.Length;
                do
                {
                    sb.Append(input[i].ToString().ToUpper());
                    i++;
                } while (input[i] != '<');
                i += closeTag.Length;
                index = input.IndexOf('<', i);
            }
            sb.Append(input[i]);
        }
        return sb.ToString(); ;
    }

    static void Main()
    {
        string sentence = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(UpcaseTag(sentence));
    }
}
