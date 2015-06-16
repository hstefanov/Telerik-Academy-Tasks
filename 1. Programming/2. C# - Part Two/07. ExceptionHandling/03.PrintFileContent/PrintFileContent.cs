using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
/// Find in MSDN how to use System.IO.File.ReadAllText(…). 
/// Be sure to catch all possible exceptions and print user-friendly error messages.
/// </summary>

class PrintFileContent
{
    static void Main()
    {
        try
        {
            string content = File.ReadAllText(@"../../test.txt");
            Console.WriteLine(content);
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.GetType().Name + " " + se.Message);
        }
    }
}
