using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter digit :");
        Console.Write("Digit = ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(digit * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(digit * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(digit * 1000);
                break;
            default:
                Console.WriteLine("Error: Invalid number!");
                break;
        }
    }
}

