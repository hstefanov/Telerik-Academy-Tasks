using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
/// Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
/// </summary>

class Permutations
{
    private static int elements = int.Parse(Console.ReadLine());
    private static int[] permutations = new int[elements];
    private static bool[] used = new bool[elements];

    public static void Print()
    {
        Console.Write("{");
        for (int i = 0; i < elements; i++)
        {
            Console.Write(" {0} ", permutations[i] + 1);
        }
        Console.WriteLine("}");
    }

    public static void Permute(int i)
    {
        if (i >= elements)
        {
            Print();
            return;
        }
        for (int j = 0; j < elements; j++)
        {
            if (!used[j])
            {
                used[j] = true;
                permutations[i] = j;
                Permute(i + 1);
                used[j] = false;
            }
        }
    }

    static void Main()
    {
        for (int i = 0; i < elements; i++)
        {
            used[i] = false;
        }
        Permute(0);
    }
}
