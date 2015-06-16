using System;

class NFactDivideByKFact
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
        Console.WriteLine("Enter K :");
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int expression = 0;

        if (k > 1 && k < n)
        {
            expression = Factorial(n) / Factorial(k);
            Console.WriteLine("{0}!/{1}! = {2}", n, k, expression);
        }
        else
        {
            Console.WriteLine("Invalid input! K must be between 1 and N");
        }      
    }
}

