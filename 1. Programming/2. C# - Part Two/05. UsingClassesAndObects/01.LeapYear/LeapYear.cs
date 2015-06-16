using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
/// </summary>

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year : ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap)
        {
            Console.WriteLine("{0} is leap year",year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year",year);
        }
    }
}
