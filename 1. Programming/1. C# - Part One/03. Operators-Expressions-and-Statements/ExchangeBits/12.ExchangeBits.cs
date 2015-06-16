using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n : ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for bit position p : ");
        Console.Write("p =");
        byte p = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for v(0 or 1) : ");
        Console.Write("v = ");
        byte v = byte.Parse(Console.ReadLine());
        int mask = 0;
        int expression = 0;

        if (v == 1)
        {
            mask = 1 << p;
            expression = n | mask;
        }
        else
        {
            mask = ~(1 << p);
            expression = n & mask;
        }
        Console.WriteLine("n={0}, p={1}, v={2} -> {3}",n,p,v,expression);
    }
}

