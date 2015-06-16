using System;

class BitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter value for v :");
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position to check : ");
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        bool isOne = false;
        int mask = 1 << p;

        int bit = (v & mask) >> p;
        if (bit == 1)
        {
            isOne = true;
            Console.WriteLine("Bit at position {0} is 1? : {1}", p, isOne);
        }
        else
        {
            Console.WriteLine("Bit at position {0} is 1? : {1}", p, isOne);
        }
    }
}

