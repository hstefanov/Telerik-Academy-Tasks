using System;
using System.Linq;


class MinAndMaxOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N :");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int len = numbers.Length;
        for (int i = 0; i < len; i++)
        {
            Console.Write("Enter value for element {0} : ",i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxElement = numbers.Max();
        int minElement = numbers.Min();
        Console.WriteLine("Min element is {0}",minElement);
        Console.WriteLine("Max element is {0}",maxElement);
    }
}

