using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program to convert decimal numbers to their hexadecimal representation.
/// </summary>

class DecToHex
{
    private static string ReverseString(string input)
    {
        string temp = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            temp += input[i];
        }
        return temp;
    }

    static void Main()
    {
        Console.Write("Enter a number : ");
        int decValue = int.Parse(Console.ReadLine());

        if (decValue < 0)
        {
            decValue = int.MaxValue + decValue + 1;
        }

        List<int> remainders = new List<int>();

        do
        {
            remainders.Add((int)(decValue % 16));
            decValue = decValue / 16;
        }
        while (decValue > 0);

        string hexNumber = "";

        foreach (var remainder in remainders)
        {
            switch (remainder)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    hexNumber += Convert.ToString(remainder);
                    break;

                case 10:
                    hexNumber += "A";
                    break;
                case 11:
                    hexNumber += "B";
                    break;
                case 12:
                    hexNumber += "C";
                    break;
                case 13:
                    hexNumber += "D";
                    break;
                case 14:
                    hexNumber += "E";
                    break;
                case 15:
                    hexNumber += "F";
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("Hex representation is: {0}",ReverseString(hexNumber));
    }
}
