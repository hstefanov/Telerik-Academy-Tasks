using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
/// Write a program to test this method.
/// </summary>

class HelloMethod
{
    public static void PrintMyName(string name)
    {
        Console.WriteLine("Hello {0}",name);
    }

    static void Main()
    {
        Console.Write("Enter your name : ");
        string yourName = Console.ReadLine();
        PrintMyName(yourName);
    }
}
