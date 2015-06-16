using System;

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter number  :");
        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine());

        bool isOne = false;
        int mask = 1 << 3;
        int bit = (number & mask) >> 3;
        if (bit == 1)
        {
            isOne = true;
        }
        Console.WriteLine("If bit at position 3 is one : {0}",isOne);
    }
}

