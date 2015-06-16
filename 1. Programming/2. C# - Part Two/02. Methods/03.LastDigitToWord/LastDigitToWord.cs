using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that returns the last digit of given integer as an English word.
/// Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
/// </summary>

class LastDigitToWord
{
    private static string[] digitWords = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
    private static int[] digits = {0,1,2,3,4,5,6,7,8,9};

    private static int GetLastDigit(int num)
    {
        return num % 10;
    }

    private static string DigitToWord(int digit)
    {
        return digitWords[digit];
    }

    static void Main()
    {
        Console.Write("Enter your number : ");
        int number = int.Parse(Console.ReadLine());

        string result = DigitToWord(GetLastDigit(number));
        Console.WriteLine("Last digit as an English word : {0} ",result);
    }
}