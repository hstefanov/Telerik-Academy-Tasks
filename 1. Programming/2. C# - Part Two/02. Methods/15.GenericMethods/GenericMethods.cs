using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
/// Use generic method (read in Internet about generic methods in C#).
/// </summary>

class GenericMethods
{
    private static T GetMax<T>(params T[] elements)
    {
        Array.Sort(elements);
        return elements[elements.Length - 1];
    }

    private static T GetMin<T>(params T[] elements)
    {
        Array.Sort(elements);
        return elements[0];
    }

    private static T GetAvarage<T>(params T[] elements)
    {
        dynamic avarage = 0;
        foreach (T num in elements)
        {
            avarage += num;
        }
        return avarage / elements.Length;
    }

    private static T GetSum<T>(params T[] elements)
    {
        dynamic sum = 0;
        foreach (T num in elements)
        {
            sum += num;
        }
        return sum;
    }

    private static T GetProduct<T>(params T[] elements)
    {
        dynamic product = 1;
        foreach (T num in elements)
        {
            product *= num;
        }
        return product;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Max element : {0}", GetMax(2.33, 4.5, -1.2, 4.1, 55.6, 0));
        Console.WriteLine("Min element : {0}", GetMin(2.33, 4.5, -1.2, 4.1, 55, 0));
        Console.WriteLine("Avarage : {0}", GetAvarage(2.33, 4.5, -1, 4.1, 55, 0));
        Console.WriteLine("Sum : {0}", GetSum(2.33, 4.5, -1, 4.1, 55, 0));
        Console.WriteLine("Product : {0}", GetProduct(2.33, 4.5, -1, 4.1, 55, 0));
    }
}
