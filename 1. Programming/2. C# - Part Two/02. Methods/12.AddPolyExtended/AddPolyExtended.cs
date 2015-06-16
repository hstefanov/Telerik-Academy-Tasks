using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Extend the program to support also subtraction and multiplication of polynomials.
/// </summary>

class AddPoly
{
    //print poly
    private static void PrintPoly(int[] poly)
    {
        for (int i = poly.Length - 1; i >= 0; i--)
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

    //sum
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

    //substract
    private static void SubTwoPoly(int[] first, int[] second, int[] substraction)
    {
        int firstIndex = first.Length - 1;
        int secondIndex = second.Length - 1;

        int counter = substraction.Length - 1;
        while (firstIndex >= 0 || secondIndex >= 0)
        {
            substraction[counter] = (firstIndex >= 0 ? first[firstIndex] : 0) - (secondIndex >= 0 ? second[secondIndex] : 0);
            firstIndex--;
            secondIndex--;
            counter--;
        }
    }

    //multiply
    private static void MultiplicationTwoPoly(int[] first, int[] second, int[] multiplication)
    {
        int firstIndex = first.Length - 1;
        int secondIndex = second.Length - 1;

        int counter = multiplication.Length - 1;
        while (firstIndex >= 0 || secondIndex >= 0)
        {
            multiplication[counter] = (firstIndex >= 0 ? first[firstIndex] : 0) * (secondIndex >= 0 ? second[secondIndex] : 0);
            firstIndex--;
            secondIndex--;
            counter--;
        }
    }

    static void Main()
    {
        //input data
        int[] firstPoly = { 5, 0, 1 };
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

        int[] additionPoly = new int[maxLength];

        //sum the polynomials
        SumTwoPoly(firstPoly, secondPoly, additionPoly);
        Console.Write("Sum of two polys : ");
        PrintPoly(additionPoly);
  
        //substract the polynomials
        int[] substractionPoly = new int[maxLength];
        SubTwoPoly(firstPoly, secondPoly, substractionPoly);
        Console.Write("Substraction of two polys : ");
        PrintPoly(substractionPoly);

        int[] multiplicationPoly = new int[maxLength];
        MultiplicationTwoPoly(firstPoly, secondPoly, multiplicationPoly);
        Console.Write("Multiplication of two polys : ");
        PrintPoly(multiplicationPoly);
    }
}
