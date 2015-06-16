using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that finds all prime numbers in the range [1...10 000 000]
/// </summary>
/// 
class SieveOfErathosthenes
{
    private static readonly int limit = 10000000;
    private static int[] sieve;

    private static void Erathosthen(int limit)
    {
        uint j = 0;
        uint i = 2;
        while (i <= limit - 1)
        {
            if (sieve[i] == 0)
            {
                Console.Write("{0} ", i);
                j = i * i;
                while (j <= limit - 1)
                {
                    sieve[j] = 1;
                    j += i;
                }
            }
            i++;
        }
    }

    static void Main()
    {
        sieve = new int[limit];
        for (int i = 2; i < limit; i++)
        {
            sieve[i] = 0;
        }
        Erathosthen(limit);
    }
}