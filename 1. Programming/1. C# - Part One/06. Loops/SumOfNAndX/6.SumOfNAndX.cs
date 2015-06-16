using System;

class SumOfNAndX
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
        Console.WriteLine("Enter N :");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X :");
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        double expression = 0;

        for (int i = 1; i <= n; i++)
        {
            expression = 1 + Factorial(i)/Math.Pow(x,i);
        }
        Console.WriteLine("The sum is : {0}",expression);
    }
}

