using System;

class NullVariable
{
    static void Main()
    {
        int? firstVar = null;
        double? secondVar = null;

        Console.WriteLine("Print nullable variables :\nfirstVar = {0}\nsecondVar = {1}",firstVar,secondVar);

        firstVar += null;
        secondVar += 3.1415926;

        Console.WriteLine("Print nullable variables :\nfirstVar = {0}\nsecondVar = {1}", firstVar, secondVar);
    }
}

