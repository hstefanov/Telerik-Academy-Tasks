using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that adds two positive integer numbers represented as arrays of digits
/// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
/// Each of the numbers that will be added could have up to 10 000 digits.
/// </summary>

class AddNumsAsArray
{
    private static byte[] StringToInt(string input)
    {
        byte[] tempArr = new byte[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            tempArr[i] = byte.Parse(input[i].ToString());
        }
        return tempArr;
    }

    private static List<int> Add(byte[] first, byte[] second)
    {
        List<int> result = new List<int>();

        int firstIndex = first.Length - 1;
        int secondIndex = second.Length - 1;

        int carry = 0;
        while (firstIndex >= 0 || secondIndex >= 0)
        {    
            int currentDigit = (firstIndex >= 0 ? first[firstIndex] : 0) + (secondIndex >= 0 ? second[secondIndex] : 0) + carry;
            carry = currentDigit / 10;
            result.Add(currentDigit % 10);
            firstIndex--;
            secondIndex--;
        }
        if(carry == 1)
        {
            result.Add(1);
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter first number : ");
        string firstInput = Console.ReadLine();
        byte[] firstNumArr = StringToInt(firstInput);

        Console.Write("Enter second number : ");
        string secondInput = Console.ReadLine();
        byte[] secondNumArr = StringToInt(secondInput);

        List<int> result = Add(firstNumArr, secondNumArr);
        Console.Write("{0} + {1} = ",firstInput,secondInput);
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

