using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program to convert hexadecimal numbers to their decimal representation.
/// </summary>

class HexToDec
{
    private static int HexToDecNum(string hexValue)
    {
        int decValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        return decValue;
    }

    static void Main()
    {
        Console.Write("Enter hex value : ");
        string hexVal = Console.ReadLine().ToUpper();
        int convertedDec = HexToDecNum(hexVal);
        Console.WriteLine("Hex value {0} to decimal : {1}",hexVal,convertedDec);

    }
}
