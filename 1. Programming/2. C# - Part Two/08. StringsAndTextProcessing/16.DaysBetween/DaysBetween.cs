using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/// <summary>
/// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
/// </summary>

class DaysBetween
{
    static void Main()
    {
        Console.WriteLine("Enter fistst date {d.MM.yyyy} : ");
        string start = Console.ReadLine();
        Console.WriteLine("Enter fistst date {d.MM.yyyy} : ");
        string end = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy",CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine((endDate - startDate).TotalDays);
    }
}
