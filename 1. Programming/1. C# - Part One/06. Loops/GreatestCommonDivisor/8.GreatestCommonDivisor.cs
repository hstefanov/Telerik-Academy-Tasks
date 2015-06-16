using System;

class GreatestCommonDivisor
{
    public static int GCD(int a,int b)
    {
        int c = 0;
        while (a != 0)
        {
            c = a;
            a = b % a;
            b = c;
        }
        return b;
    }
    static void Main()
    {
        Console.Write("Enter first Number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second Number : ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = GCD(num1, num2);
        Console.WriteLine("Greatest Common Divisor of {0} and {1} is {2}", num1, num2, gcd);
    }
}

