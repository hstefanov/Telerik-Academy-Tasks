using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        BigInteger member1 = 0;
        BigInteger member2 = 1;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(member1);
            BigInteger member3 = member1 + member2;
            member1 = member2;
            member2 = member3;
        }
    }
}

