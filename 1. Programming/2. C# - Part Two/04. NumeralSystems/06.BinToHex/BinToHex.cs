using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinToHex
{
    private static string BinToHexDirectrly(string binValue)
    {
        string hexValue = string.Empty;
        hexValue = Convert.ToString(Convert.ToInt32(binValue, 2), 16);
        return hexValue.ToUpper();
    }

    static void Main()
    {
        Console.Write("Enter binary sequence : ");
        string bin = Console.ReadLine();
        string hex = BinToHexDirectrly(bin);
        Console.WriteLine("Hex representation of {0} : {1}",bin,hex);
    }
}
