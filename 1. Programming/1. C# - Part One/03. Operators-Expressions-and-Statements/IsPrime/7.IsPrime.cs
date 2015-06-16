using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter value for n : ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;
        int divider = 2;
        int maxdivider = (int)Math.Sqrt(divider);
        while (isPrime && (divider <= maxdivider))
        {
            if (n % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }
        Console.WriteLine("Is {0} primer? : {1}",n,isPrime);
    }
}
