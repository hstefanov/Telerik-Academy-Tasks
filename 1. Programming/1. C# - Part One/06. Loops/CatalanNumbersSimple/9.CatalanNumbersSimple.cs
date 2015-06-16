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
        int n = 5;
        decimal catalan = Factorial(2 * n) / Factorial(1 + n) * Factorial(n);
        Console.WriteLine("Catalan number for n = {0} : {1} ",n, catalan);
    }
}

