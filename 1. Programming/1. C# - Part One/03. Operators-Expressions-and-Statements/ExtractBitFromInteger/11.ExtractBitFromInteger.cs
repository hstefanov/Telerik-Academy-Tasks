using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter value for i : ");
        Console.Write("i = ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit number to extract : ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int bit = (i & mask) >> b;
        Console.WriteLine("Bit at position {0} is {1}", b, bit);
    }
}

