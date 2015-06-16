using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter N :");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

