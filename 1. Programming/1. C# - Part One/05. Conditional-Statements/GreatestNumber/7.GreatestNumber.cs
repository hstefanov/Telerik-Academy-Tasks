using System;
using System.Linq;

class GreatestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter five variables ");

        int[] variables = new int[5];
        for (int i = 0; i < 5; i++)
        {
            variables[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Greatest number is {0} :",variables.Max());
    }
}

