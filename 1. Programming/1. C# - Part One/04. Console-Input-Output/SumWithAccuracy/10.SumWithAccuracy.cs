using System;

class Program
{
    static void Main()
    {
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;
        while (1m / counter > 0.001m)
        {
            sum = sum + (1m / counter) * sign;
            sign = sign * (-1);
            counter++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);
    }
}

