using System;

class CopyrightTriangle
{
    static void Main()
    {
        char copyright = '\u00A9';

        for (int row = 0, col = 3 , counter = 1; row < 3; row++, col--, counter++)
        {
            Console.Write(new string(' ',col));
            Console.WriteLine(new string(copyright, row + counter));
        }
    }
}

