using System;

class First100ElementsOfFibonacci
{
    public static int FibonacciSum(int number)
    {
        int firstFib = 0;
        int secondFib = 1;
        int tempFib = 0;
        int sum = firstFib + secondFib;
        for (int i = 2; i < number; i++)
        {
            tempFib = firstFib + secondFib;
            sum += tempFib;
            firstFib = secondFib;
            secondFib = tempFib;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter N :");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = FibonacciSum(n);
        Console.WriteLine("The sum of first {0} members of Fibonacci sequence is {1}",n,sum);
    }
}

