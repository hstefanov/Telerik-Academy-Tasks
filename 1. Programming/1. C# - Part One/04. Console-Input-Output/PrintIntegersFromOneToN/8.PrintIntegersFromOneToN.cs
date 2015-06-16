using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for n : ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

