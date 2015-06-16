using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program to convert hexadecimal numbers to binary numbers (directly).
/// </summary>

class HexToBin
{
    private static string HexToBinDirectly(string hexValue)
    {
        string binValue = string.Empty;
        binValue = Convert.ToString(Convert.ToInt32(hexValue, 16), 2);

        return binValue;
    }

    static void Main()
    {
        Console.Write("Enter hex value : ");
        string hex = Console.ReadLine();

        string bin = HexToBinDirectly(hex);
        Console.WriteLine("{0} in binary : {1}",hex,bin);
    }
}
