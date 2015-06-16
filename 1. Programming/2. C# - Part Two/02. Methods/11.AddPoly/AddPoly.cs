using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that adds two polynomials. 
/// Represent them as arrays of their coefficients as in the example below:	x2 + 5 = 1x2 + 0x + 5 -> 5 0 1
/// </summary>

class AddPoly
{
    //print poly
    private static void PrintPoly(int[] poly)
    {
        for (int i = poly.Length - 1; i >= 0 ; i--)
        {
            if (i != 0)
            {
                if (poly[i] != 0 && i != 0)
                {
                    Console.Write("{0}x^{1} + ", poly[i], i);
                }
                else
                {
                    Console.Write("{0} + ", poly[i]);
                }
            }
            else
            {
                if (poly[i] != 0 && i != 0)
                {
                    Console.Write("{0}x^{1}", poly[i], i);
                }
                else
                {
                    Console.Write("{0}", poly[i]);
                }
            }
        }
        Console.WriteLine();
    }

    private static void SumTwoPoly(int[] first, int[] second, int[] addition)
    {
        int firstIndex = first.Length - 1;
        int secondIndex = second.Length - 1;

        int counter = addition.Length - 1;
        while (firstIndex >= 0 || secondIndex >= 0)
        {
            addition[counter] = (firstIndex >= 0 ? first[firstIndex] : 0) + (secondIndex >= 0 ? second[secondIndex] : 0);
            firstIndex--;
            secondIndex--;
            counter--;
        }
    }

    static void Main()
    {
        //input data
        int[] firstPoly = { 5,0,1 };
        Console.Write("First polynomial : ");
        PrintPoly(firstPoly);

        int[] secondPoly = { 10, -5, 6 };
        Console.Write("Second polynomial : ");
        PrintPoly(secondPoly);

        int maxLength = 0;
        if (firstPoly.Length > secondPoly.Length)
        {
            maxLength = firstPoly.Length;
        }
        else
        {
            maxLength = secondPoly.Length;
        }

        int[] result = new int[maxLength];

        //sum the polynomials
        SumTwoPoly(firstPoly, secondPoly, result);
        Console.Write("Sum of two polys : ");
        PrintPoly(result);
    }
}
