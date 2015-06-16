using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that can solve these tasks:
///Reverses the digits of a number
///Calculates the average of a sequence of integers
///Solves a linear equation a * x + b = 0
///Create appropriate methods.
///Provide a simple text-based menu for the user to choose which task to solve.
///Validate the input data:
///The decimal number should be non-negative
///The sequence should not be empty
///a should not be equal to 0
/// </summary>

class SolveDifferentTasks
{
    private static string[] menu = {"","1.Reverse digits","2.AvaregeSum","3.LinearEquation"};

    //reverse
    private static string ReverseTheDigits(decimal number)
    {
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        string result = string.Empty;
        for (int i = 0; i < digits.Length; i++)
        {
            result += digits[i];
        }
        return result;
    }

    //avarage 
    private static double GetAvarage(int[] seq)
    {
        double avarage = 0;
        for (int i = 0; i < seq.Length; i++)
        {
            avarage += seq[i];
        }
        avarage = avarage / seq.Length;
        return avarage;
    }

    //equation
    private static double SolsveEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void Main()
    {
        Console.WriteLine("Please enter below the number of method you want to use:");
        for (int i = 1; i < menu.Length; i++)
        {
            Console.WriteLine(menu[i]);
        }
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                decimal inputNum;
                do
                {
                    Console.WriteLine("Enter non-negative decimal number! : ");
                    inputNum = decimal.Parse(Console.ReadLine());
                } while (inputNum < 0);
                string reversedNum = ReverseTheDigits(inputNum);
                Console.WriteLine("Reversed decimal number : {0}",reversedNum);
                break;
            case 2:
                Console.WriteLine("Enter length of the sequence you want to calculate : ");
                int len;
                do
                {
                    Console.WriteLine("Sequence must be non-empty!");
                    len = int.Parse(Console.ReadLine());
                } while (len <= 0);
                int[] sequence = new int[len];
                for (int i = 0; i < len; i++)
                {
                    Console.Write("Enter element {0} : ", i);
                    sequence[i] = int.Parse(Console.ReadLine());
                }
                double result = GetAvarage(sequence);
                Console.Write("Avarage of a sequence of integers : ");
                Console.WriteLine(result);
                break;
            case 3:
                Console.WriteLine("Enter values for 'a' and 'b' : ");
                int a;
                do
                {
                    Console.Write("Enter value for 'a' : ");
                    a = int.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("a should not be equal to zero!");
                    }
                } while (a == 0);
                Console.Write("Enter value for 'b' : ");
                int b = int.Parse(Console.ReadLine());
                string x = -(b) + "/" + a;
                Console.WriteLine("x = {0}", x);
                double equation;
                equation = SolsveEquation(a, b);
                Console.WriteLine("Equation : {0}",equation);
                break;
        }
    }
}
