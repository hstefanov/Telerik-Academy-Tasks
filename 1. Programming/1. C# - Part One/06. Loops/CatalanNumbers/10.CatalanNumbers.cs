using System;

class CatalanNumbers
{
    public static int Factorial(int number)
    {
        int factorial = 1;
        do
        {
            factorial *= number;
            number--;
        } while (number > 0);
        return factorial;
    }

    static void Main()
    {
        Console.WriteLine("Enter value for N :");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        if(n >= 0)
        {
            decimal catalan = Factorial(2 * n) / Factorial(1 + n) * Factorial(n);
            Console.WriteLine("Catalan number = {0}",catalan);
        }
    }
}

