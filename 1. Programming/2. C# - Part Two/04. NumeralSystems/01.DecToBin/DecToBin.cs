using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program to convert decimal numbers to their binary representation.
/// </summary>

class DecToBin
{
    private static string DecToBinNum(int num)
    {
        string result = string.Empty;
        while (num > 0)
        {
            result += num % 2;
            num /= 2;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter number to convert into binary :");
        int inputNum = int.Parse(Console.ReadLine());
        string binaryNum = DecToBinNum(inputNum);

        //reverse
        for (int i = binaryNum.Length - 1; i >=0 ; i--)
        {
            Console.Write(binaryNum[i]);
        }
        Console.WriteLine();

        //test program
        string binaryNumEmbedded = Convert.ToString(inputNum, 2);
        Console.WriteLine(binaryNumEmbedded);

        if (binaryNum.CompareTo(binaryNumEmbedded) == 1)
        {
            Console.WriteLine("Method DecToBinNum works correctly!");
        }
    }
}
