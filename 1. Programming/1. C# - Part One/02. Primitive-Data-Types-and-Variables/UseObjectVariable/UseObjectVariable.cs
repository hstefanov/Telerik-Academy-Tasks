using System;

class UseObjectVariable
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object stringConcatenation = firstString + " " + secondString;
        string thirdString = stringConcatenation.ToString();
        Console.WriteLine(thirdString);
    }
}

