﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that prints to the console which day of the week is today. Use System.DateTime.
/// </summary>

class WhichDayOfWeek
{
    static void Main()
    {
        Console.WriteLine("Today is : {0}",DateTime.Today.DayOfWeek);
    }
}
