using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that reverses the digits of given decimal number. Example: 256 -> 652
/// </summary>

class ReverseDigits
{
    private static string ReverseTheDigits(decimal number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        string result = string.Empty;
        for (int i = 0; i < digits.Length; i++)
        {
            result += digits[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter number : ");
        decimal num = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed decimal : {0}",ReverseTheDigits(num));
    }
}
