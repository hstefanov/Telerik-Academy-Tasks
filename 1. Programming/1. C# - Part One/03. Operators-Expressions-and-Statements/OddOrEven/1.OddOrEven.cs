using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number to check :");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
}

