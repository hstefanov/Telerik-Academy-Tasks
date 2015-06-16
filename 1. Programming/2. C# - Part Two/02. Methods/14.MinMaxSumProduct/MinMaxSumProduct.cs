using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
/// Use variable number of arguments.
/// </summary>

class MinMaxSumProduct
{
    private static int GetMax(params int[] elements)
    {
        Array.Sort(elements);
        return elements[elements.Length - 1];
    }

    private static int GetMin(params int[] elements)
    {
        Array.Sort(elements);
        return elements[0];
    }

    private static double GetAvarage(params int[] elements)
    {
        double avarage = 0;
        foreach (int num in elements)
        {
            avarage += num;
        }
        return avarage / elements.Length;
    }

    private static int GetSum(params int[] elements)
    {
        int sum = 0;
        foreach (int num in elements)
        {
            sum += num;
        }
        return sum;
    }

    private static int GetProduct(params int[] elements)
    {
        int product = 1;
        foreach (int num in elements)
        {
            product *= num;
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Max element : {0}", GetMax(1, 2, 3, 4, 55,0));
        Console.WriteLine("Min element : {0}", GetMin(1, 2, 3, 4, 55,0));
        Console.WriteLine("Avarage : {0}", GetAvarage(1, 2, 3, 4, 55,0));
        Console.WriteLine("Sum : {0}", GetSum(1, 2, 3, 4, 55));
        Console.WriteLine("Product : {0}", GetProduct(1, 2, 3, 4, 55));
    }
}
