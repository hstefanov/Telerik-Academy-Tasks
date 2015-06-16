using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a method that calculates the number of workdays between today and given date, passed as parameter. 
/// Consider that workdays are all days from Monday to Friday
/// except a fixed list of public holidays specified preliminary as array.
/// </summary>

class Workdays
{
    private static DateTime[] holidays = { new DateTime(2014, 12, 24), new DateTime(2014, 12, 25), new DateTime(2014, 12, 31) };

    private static int FilterHolidays(DateTime start, DateTime end, int result)
    {
        foreach(DateTime holiday in holidays)
        {
            if (start <= holiday && holiday <= end 
                && !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
            {
                result--;
            }
        }
        return result;
    }

    private static void TrimPeriod(ref DateTime start,ref DateTime end)
    {
        //Trim if it starts with a weekend
        if (start.DayOfWeek == DayOfWeek.Saturday)
        {
            start = start.AddDays(2);
        }
        if(start.DayOfWeek == DayOfWeek.Sunday)
        {
            start = start.AddDays(1);
        }
        
        //Trim if it ends with a weekend
        if (end.DayOfWeek == DayOfWeek.Saturday)
        {
            end.AddDays(-1);
        }
        if (end.DayOfWeek == DayOfWeek.Sunday)
        {
            end.AddDays(-2);
        }
    }

    private static int GetWordDays(DateTime start,DateTime end)
    {
        if(end < start)
        {
            return GetWordDays(end,start);
        }

        TrimPeriod(ref start, ref end);

        int offset = (int)(end - start).TotalDays + 1;

        int result = offset / 7 * 5 + offset % 7;

        return (FilterHolidays(start, end, Math.Max(result, 0)));
    }

    static void Main()
    {
        Console.WriteLine(GetWordDays(new DateTime(2014,1,7),new DateTime(2014,12,31)));
    }
}
