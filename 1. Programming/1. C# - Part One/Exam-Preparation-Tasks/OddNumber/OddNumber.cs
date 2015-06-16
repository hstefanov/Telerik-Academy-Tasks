using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long result = 0;

        for (long i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            result ^= number;
        }

        Console.WriteLine(result);
    }
}

