using System;

class QuotedString
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("Quoted string : {0}",quotedString);
        string nonQuotedString = "The use of quotations causes difficulties.";
        Console.WriteLine("Non quoted string : {0}",nonQuotedString);
    }
}

