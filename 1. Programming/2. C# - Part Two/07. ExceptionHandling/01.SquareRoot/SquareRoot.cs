using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads an integer number and calculates and prints its square root. 
/// If the number is invalid or negative, print "Invalid number". 
/// In all cases finally print "Good bye". Use try-catch-finally.
/// </summary>

class SquareRoot
{
    public static void FindSquare(uint num)
    {
        Console.WriteLine(Math.Sqrt(num));
    }
    static void Main()
    {
        try
        {
            uint num = uint.Parse(Console.ReadLine());
            FindSquare(num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid Number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
