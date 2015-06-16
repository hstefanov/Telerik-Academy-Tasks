using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinToDec
{
    private static int BinToDecNum(string input)
    {
        int result = 0;
        for (int i = input.Length - 1, degree = 0; i >= 0; i--, degree++)
        {
            result += int.Parse(input[i].ToString()) * (int)Math.Pow(2, degree);
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter binary number to convert : ");
        string binNum = Console.ReadLine();
        int decNum = BinToDecNum(binNum);
        Console.WriteLine("Result : {0}",decNum);

        //test program
        int testDecNum = Convert.ToInt32(binNum, 2);
        Console.WriteLine("Embedded convert : " + testDecNum);
        if (decNum == testDecNum)
        {
            Console.WriteLine("Mehtod BinToDecNum works correctly!");
        }
    }
}
