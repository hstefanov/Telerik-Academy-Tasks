using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 255; i++)
        {
            char code = (char)i;
            Console.WriteLine("Character {0} = {1}", i, code);
        }
    }
}

